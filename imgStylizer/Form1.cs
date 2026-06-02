namespace imgStylizer
{
    public partial class Form1 : Form
    {

        List<Color> imgColors;
        List<MyColor> imgMyColors;
        public Form1()
        {
            InitializeComponent();
            /*
            imgColors = [Color.FromArgb(255, 255, 255),
                         Color.FromArgb(177, 52, 37),
                         Color.FromArgb(227, 157, 37),
                         Color.FromArgb(106, 107, 4)];
            */
            imgColors = [];
            imgMyColors = [];
            Bitmap originalImg = (Bitmap)Originalimg.Image;
            for (int x = 0; x < originalImg.Width; x++)
            {
                for (int y = 0; y < originalImg.Height; y++)
                {
                    imgColors.Add(originalImg.GetPixel(x, y));
                    imgMyColors.Add(new MyColor(originalImg.GetPixel(x, y)));
                }
            }
            imgMyColors.Sort();
            List<Color> SortedImgColors = imgColors.OrderBy(color => color.R * 256 * 256 + color.B * 256 + color.G).ToList();
            foreach (MyColor color in imgMyColors)
            {
                //MessageBox.Show($"R: {color.Color.R} B: {color.Color.B} G: {color.Color.G}");
            }

            Color[,] colors = new Color[10, originalImg.Width * originalImg.Height/10];
            for(int i = 0; i < colors.GetLength(0); i++)
            {
                for (int j = 0; j < colors.GetLength(1); j++)
                {
                    colors[i, j] = SortedImgColors[i * colors.GetLength(1) +j];
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap originalImg = (Bitmap)Originalimg.Image;
            Bitmap newImg = new Bitmap(originalImg.Width,originalImg.Height);
            Bitmap bestImg = new Bitmap(originalImg.Width, originalImg.Height);

            Random rand = new Random();
            for (int j = 0; j < 5; j++)
            {
                Bitmap bestGenerationImg = (Bitmap)bestImg.Clone();
                long bestScore = long.MaxValue;
                for (int i = 0; i < 100; i++)
                {
                    newImg = (Bitmap)bestImg.Clone();
                    //generate start point 
                    int x1 = rand.Next(newImg.Width);
                    int y1 = rand.Next(newImg.Height);
                    //generate end point
                    int x2 = x1 + rand.Next(newImg.Width - x1);
                    int y2 = y1 + rand.Next(newImg.Height - y1);
                    //generate color
                    var pixelcolor = imgColors[rand.Next(imgColors.Count)];
                    int r = pixelcolor.R;
                    int b = pixelcolor.B;
                    int g = pixelcolor.G;
                    var newPixel = Color.FromArgb(r, g, b);
                    //draw rectangle
                    for (int x = x1; x < x2; x++)
                    {
                        for (int y = y1; y < y2; y++)
                        { 
                            newImg.SetPixel(x, y, newPixel);
                        }
                    }
                    //score rectangle
                    long score = 0;
                    for (int x = 0; x < newImg.Width; x++)
                    {
                        for (int y = 0; y < newImg.Height; y++)
                        {
                            var origianlPixel = originalImg.GetPixel(x, y);
                            score += (long)(Math.Pow(Math.Abs(origianlPixel.R - r), 4) + 
                                            Math.Pow(Math.Abs(origianlPixel.B - b), 4) + 
                                            Math.Pow(Math.Abs(origianlPixel.G - g), 4));
                        }
                    }
                    if (score < bestScore)
                    {
                        bestScore = score;
                        bestGenerationImg = (Bitmap)newImg.Clone();
                    }
                    //MessageBox.Show($"Score: {score}");
                }
                bestImg = (Bitmap)bestGenerationImg.Clone();
            }
            Generatedimg.Image = bestImg;
        }
    }
}
