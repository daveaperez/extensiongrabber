using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace ExtensionGrabber {
    public class EG {
        public string SourceDirectory { get; set; }
        public string DestinationDirectory { get; set; }
        public string Extension { get; set; }
        public bool AutoOverwrite { get; set; }
        public EG() {
            SourceDirectory = string.Empty;
            DestinationDirectory = string.Empty;
            Extension = string.Empty;
            AutoOverwrite = false;
        }

        public EG(string src, string dest, string ext) {
            SourceDirectory = src;
            DestinationDirectory = dest;
            Extension = ext;
            AutoOverwrite = false;
        }

        public bool IsSourceValid() {
            return Directory.Exists(SourceDirectory);
        }

        public string[] NumberOfFiles() {
            if (!IsSourceValid())
                throw new IOException("Directory does not exist");
            string extFilter = string.Format("*.{0}", Extension);
            var fileList = 
                Directory.EnumerateFiles(SourceDirectory, extFilter, SearchOption.AllDirectories);
            return fileList.ToArray();
        }

        public void Copy(bool autoOverwrite) {
            string[] fileList = NumberOfFiles();
            foreach (string file in fileList) {
                string fileNameOnly = Path.GetFileName(file);
                string destPathWithFilename = Path.Combine(DestinationDirectory, fileNameOnly);
                if(File.Exists(destPathWithFilename)) {
                    string msg = string.Format("{0} exists. Overwrite?", file);
                    if (!autoOverwrite) {
                        DialogResult rslt = MessageBox.Show(msg, "File Exists", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (rslt == DialogResult.No)
                            continue;
                    }
                }
                File.Copy(file, destPathWithFilename, true);
            }
        }
    }
}
