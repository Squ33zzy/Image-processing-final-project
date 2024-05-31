using OpenCvSharp;
using OpenCvSharp.Extensions;



namespace ImageProcessingPrj
{
    public partial class ImageProcessing : Form
    {
        Mat IpImg;
        Mat OpImg;
        public ImageProcessing()
        {
            InitializeComponent();
        }


        private void browseBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            IpImg = Cv2.ImRead(ofd.FileName, OpenCvSharp.ImreadModes.Grayscale);
            pictureBox1.Image = IpImg.ToBitmap();
        }
        
                    
        private void runBtn_Click(object sender, EventArgs e)
        {
            switch (choiceBox.SelectedItem.ToString())
            {
                case "Laplacian Filter":
                    OpImg = ProcessFunc.laplacianFilter(IpImg);

                    break;
                case "Sobel Filter":
                    OpImg = ProcessFunc.sobelFilter(IpImg);
                    break;
                case "Mean Filter":
                    OpImg= ProcessFunc.meanFilter(IpImg,3);
                    break;
                case "Median Filter":
                    OpImg = ProcessFunc.medianFilter(IpImg,3);
                    break;
                default: OpImg = IpImg; break;
            }
            pictureBox2.Image = OpImg.ToBitmap();
        }
    }
}
