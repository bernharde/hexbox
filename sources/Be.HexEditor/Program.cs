using Be.HexEditor.Properties;
using Be.HexEditor.Theme;
using System;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace Be.HexEditor;

internal static class Program
{
    public const string SoftwareName = "Be.HexEditor";

   public static CultureInfo InitialCulure { get; } = Thread.CurrentThread.CurrentCulture;
   public static CultureInfo InitialUICulure { get; } = Thread.CurrentThread.CurrentUICulture;

    public static FormHexEditor? MainForm { get; set; }

    [STAThread]
    static void Main(string[] args)
    {
        SetCulture();

        Application.EnableVisualStyles();
        Application.SetHighDpiMode(HighDpiMode.PerMonitorV2);
        Application.SetCompatibleTextRenderingDefault(false);

        Application.SetColorMode(UiManagerComponent.CurrentSystemColorMode);


        using var form = new FormHexEditor();
        MainForm = form;

        if (args.Length > 0 && File.Exists(args[0]))
        {
            form.OpenFile(args[0]);
        }

        Application.Run(form);
    }

    public static void SetCulture()
    {
        if (!Settings.Default.UseSystemLanguage)
        {
            var culture = new CultureInfo(Settings.Default.SelectedLanguage);
            Thread.CurrentThread.CurrentUICulture = culture;
            Thread.CurrentThread.CurrentCulture = culture;
        }
        else
        {
            Thread.CurrentThread.CurrentUICulture = InitialUICulure;
            Thread.CurrentThread.CurrentCulture = InitialCulure;
        }
    }

    public static DialogResult ShowError(Exception ex) =>
      ShowError(ex.Message);

    public static DialogResult ShowError(string text) =>
      MessageBox.Show(text, SoftwareName,
        MessageBoxButtons.OK,
        MessageBoxIcon.Error);

    public static void ShowMessage(string text) =>
      MessageBox.Show(text, SoftwareName,
        MessageBoxButtons.OK,
        MessageBoxIcon.Information);

    public static DialogResult ShowQuestion(string text) =>
      MessageBox.Show(text, SoftwareName,
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question);
}