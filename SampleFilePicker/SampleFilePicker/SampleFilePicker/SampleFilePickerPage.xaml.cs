using Plugin.FilePicker;
using Plugin.FilePicker.Abstractions;
using Xamarin.Forms;

namespace SampleFilePicker
{
    public partial class SampleFilePickerPage : ContentPage
    {
        public SampleFilePickerPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            this.btnFileSelect.Clicked += async (sender, e) =>
            {
                // ファイルピッカーを開く
                IFilePicker filePicker = CrossFilePicker.Current;
                FileData fileData = await filePicker.PickFile();

                if (fileData != null)
                {
                    // 選択したファイルの名称を表示
                    this.lblFileName.Text = fileData.FileName;
                }
            };
        }
    }
}
