using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoLibrary;
using MediaToolkit;
using System.IO;
using MediaToolkit.Model;


namespace giris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Boolean format = true;
        private async void indir_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog() { Description = "Klasör seçiniz" })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("İndirme Başladı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    var ytb = YouTube.Default;
                    var video = await ytb.GetVideoAsync(link.Text);
                    File.WriteAllBytes(dialog.SelectedPath + @"\" + video.FullName, await video.GetBytesAsync());

                    var input = new MediaToolkit.Model.MediaFile { Filename = dialog.SelectedPath + @"\" + video.FullName };
                    var output = new MediaToolkit.Model.MediaFile { Filename = $"{dialog.SelectedPath + @"\" + video.FullName}.mp3" };

                    using (var engine = new Engine())
                    {
                        engine.GetMetadata(input);
                        engine.Convert(input, output);
                    }
                    if (format == true)
                    {
                        File.Delete(dialog.SelectedPath + @"\" + video.FullName);
                    }
                    else
                    {
                        File.Delete($"{dialog.SelectedPath + @"\" + video.FullName}.mp3");

                    }
                    progressBar1.Value = 100;
                    MessageBox.Show("İndirme Tamamlandı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Doya Seçin", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void mp3_CheckedChanged(object sender, EventArgs e)
        {
            format = true;
        }

        private void mp4_CheckedChanged(object sender, EventArgs e)
        {
            format = false;
        }
    }
}
