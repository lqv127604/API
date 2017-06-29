using System.IO;
using System.Text;

namespace Core
{
    public class Resource
    {
        /// <summary>
        /// Tạo tập tin trống mới
        /// </summary>
        /// <param name="path"></param>
        public static void CreateFile(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
            {
                return;
            }

            File.Create(path);
        }

        /// <summary>
        /// Tập thư mục mới, thư mục có rồi không báo lỗi
        /// </summary>
        /// <param name="path"></param>
        public static void CreateFolder(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
            {
                return;
            }

            Directory.CreateDirectory(path);
        }

        /// <summary>
        /// Thực hiện xóa tập tin
        /// </summary>
        /// <param name="path"></param>
        public static void DeleteFile(string path)
        {
            File.Delete(path);
        }

        /// <summary>
        /// Trả về một stream để gửi dữ liệu về cho người dùng
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static FileStream GetFileStream(string path)
        {
            if (string.IsNullOrWhiteSpace(path) || !File.Exists(path))
            {
                return null;
            }

            return new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read, 102400, true);
        }

        /// <summary>
        /// Ghi nội dung text vào trong một tập tin, có cho phép chèn thêm hoặc không
        /// </summary>
        /// <param name="path"></param>
        /// <param name="content"></param>
        /// <param name="append"></param>
        public void WriteText(string path, string content, bool append)
        {
            if (string.IsNullOrWhiteSpace(path))
            {
                return;
            }

            FileStream file = null;
            if (append == true)
            {
                file = new FileStream(path, FileMode.Append, FileAccess.Write, FileShare.Read, 102400, true);
            }
            else
            {
                file = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.Read, 102400, true);
            }

            using (var stream = new StreamWriter(file, Encoding.UTF8, 10240, false))
            {
                stream.Write(content);
            }
        }
    }
}