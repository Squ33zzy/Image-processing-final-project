    using OpenCvSharp;
    namespace ImageProcessingPrj
    {
        public class ProcessFunc
        {
            public static Mat meanFilter(Mat ImgInput, int kernelSize)
            {
                // Tạo ảnh đầu ra với cùng kích thước và loại dữ liệu như ảnh đầu vào
                Mat ImgOutput = new Mat(ImgInput.Size(), ImgInput.Type());

                // Đảm bảo kernelSize là số lẻ và >= 3
                if (kernelSize % 2 == 0 || kernelSize < 3)
                {
                    throw new ArgumentException("Kernel size must be an odd number and greater than or equal to 3.");
                }

                int border = kernelSize / 2;

                // Lặp qua từng điểm ảnh của ảnh đầu vào, ngoại trừ biên của ảnh
                for (int y = border; y < ImgInput.Rows - border; y++)
                {
                    for (int x = border; x < ImgInput.Cols - border; x++)
                    {
                        // Tính giá trị trung bình của các điểm ảnh trong cửa sổ kích thước kernelSize x kernelSize
                        int sum = 0;
                        for (int ky = -border; ky <= border; ky++)
                        {
                            for (int kx = -border; kx <= border; kx++)
                            {
                                sum += ImgInput.At<byte>(y + ky, x + kx);
                            }
                        }

                        int mean = sum / (kernelSize * kernelSize);

                        // Gán giá trị trung bình cho điểm ảnh tương ứng trong ảnh đầu ra
                        ImgOutput.Set(y, x, (byte)mean);
                    }
                }

                // Trả về ảnh đầu ra đã được áp dụng bộ lọc trung bình
                return ImgOutput;
            }
            public static Mat medianFilter(Mat ImgInput, int kernelSize)
            {
                // Tạo ảnh đầu ra với cùng kích thước và loại dữ liệu như ảnh đầu vào
                Mat ImgOutput = new Mat(ImgInput.Size(), ImgInput.Type());

                // Đảm bảo kernelSize là số lẻ và >= 3
                if (kernelSize % 2 == 0 || kernelSize < 3)
                {
                    throw new ArgumentException("Kernel size must be an odd number and greater than or equal to 3.");
                }

                int border = kernelSize / 2;

                // Lặp qua từng điểm ảnh của ảnh đầu vào, ngoại trừ biên của ảnh
                for (int y = border; y < ImgInput.Rows - border; y++)
                {
                    for (int x = border; x < ImgInput.Cols - border; x++)
                    {
                        // Lấy các điểm ảnh trong cửa sổ kích thước kernelSize x kernelSize
                        List<byte> neighbors = new List<byte>();

                        for (int ky = -border; ky <= border; ky++)
                        {
                            for (int kx = -border; kx <= border; kx++)
                            {
                                neighbors.Add(ImgInput.At<byte>(y + ky, x + kx));
                            }
                        }

                        // Sắp xếp các giá trị và lấy giá trị trung vị
                        neighbors.Sort();
                        byte median = neighbors[neighbors.Count / 2];

                        // Gán giá trị trung vị cho điểm ảnh tương ứng trong ảnh đầu ra
                        ImgOutput.Set(y, x, median);
                    }
                }

                // Trả về ảnh đầu ra đã được áp dụng bộ lọc trung vị
                return ImgOutput;
            }

       
            public static Mat sobelFilter(Mat ImgInput)
            {
                //Tạo ảnh đầu ra có kích thước và kiểu giống ảnh đầu vào
                 Mat ImgOutput = new Mat(ImgInput.Size(), ImgInput.Type());
                // Tạo hai ma trận lọc 
                int[] Gx = { -1, -2, -1, 0, 0, 0, 1, 2, 1 };
                int[] Gy = { -1, 0, 1, -2, 0, 2, -1, 0, 1 };
                //Chuyển ảnh đầu ra về ảnh đen để làm sạch 
                for (int y = 0; y < ImgInput.Rows; y++)
                 {
                     for (int x = 0; x < ImgInput.Cols; x++)
                     {
                         ImgOutput.Set<byte>(y, x, 0);
                     }
                 }

                 double AGx = 0.0;
                 double AGy = 0.0;
                //Duyệt các vị trí trong ảnh
                 for (int y = 1; y < ImgInput.Rows - 1; y++)
                 {
                     for (int x = 1; x < ImgInput.Cols - 1; x++)
                     {
                        // Áp dụng công thức của bộ lọc Sobel
                         AGx = ImgInput.At<byte>(y - 1, x - 1) * Gx[0]
                             + ImgInput.At<byte>(y - 1, x) * Gx[1]
                             + ImgInput.At<byte>(y - 1, x + 1) * Gx[2]
                             + ImgInput.At<byte>(y, x - 1) * Gx[3]
                             + ImgInput.At<byte>(y, x) * Gx[4]
                             + ImgInput.At<byte>(y, x + 1) * Gx[5]
                             + ImgInput.At<byte>(y + 1, x - 1) * Gx[6]
                             + ImgInput.At<byte>(y + 1, x) * Gx[7]
                             + ImgInput.At<byte>(y + 1, x + 1) * Gx[8];
                         AGy = ImgInput.At<byte>(y - 1, x - 1) * Gy[0]
                            + ImgInput.At<byte>(y - 1, x) * Gy[1]
                            + ImgInput.At<byte>(y - 1, x + 1) * Gy[2]
                            + ImgInput.At<byte>(y, x - 1) * Gy[3]
                            + ImgInput.At<byte>(y, x) * Gy[4]
                            + ImgInput.At<byte>(y, x + 1) * Gy[5]
                            + ImgInput.At<byte>(y + 1, x - 1) * Gy[6]
                            + ImgInput.At<byte>(y + 1, x) * Gy[7]
                            + ImgInput.At<byte>(y + 1, x + 1) * Gy[8];


                    
                         double value = AGx + AGy;

                         if (value > 127) value = 255;

                         else value = 0;
                         // Gán giá trị cho ảnh
                         ImgOutput.Set(y, x, (byte)value);
                     }

                 }
                return ImgOutput;
           }
           public static Mat laplacianFilter (Mat ImgInput)
            {
                //Tạo ảnh đầu ra có kích thước và kiểu giống ảnh đầu vào
                Mat ImgOutput = new Mat(ImgInput.Size(),ImgInput.Type());
           
                for (int y = 1; y < ImgInput.Rows - 1; y++)
                {
                    for (int x = 1; x < ImgInput.Cols - 1; x++)
                    {
                        // Áp dụng công thức của bộ lọc Laplacian
                        int sum = ImgInput.At<byte>(y - 1, x)
                                + ImgInput.At<byte>(y + 1, x)
                                + ImgInput.At<byte>(y, x - 1)
                                + ImgInput.At<byte>(y, x + 1)
                                - 4 * ImgInput.At<byte>(y, x);

                        // Gán giá trị cho ảnh đầu ra
                        ImgOutput.Set(y, x, (byte)Math.Clamp(sum, 0, 255));
                    }
                }
                return ImgOutput;
            }
        }
    }
