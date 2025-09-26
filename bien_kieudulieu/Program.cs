// khai báo biến:
// cú pháp: <kiểu dữ liệu> <tên biến> = <giá trị>;
// int age = 25; // số nguyên
// double price = 19.99 // số thực
// char grade = 'A'; // ký tự
// string name = "Tâm" //chuỗi
// bool isStutent = true // đúng/sai (true/false)

internal class Program
{
    private static void Main(string[] args)
    {
        // Ôn tập bài Hello word
        // Console.WriteLine("Chào mừng bạn đến với C#");
        // Console.Write("Nhập tên của bạn: ");
        // string name = Console.ReadLine();
        // Console.WriteLine($"Xin chào bạn: {name}!");

        // int a = 10;
        // int b = 3;
        // Console.WriteLine("Tổng: " + (a + b));
        // Console.WriteLine("Hiệu: " + (a - b));
        // Console.WriteLine("Tích: " + (a * b));
        // Console.WriteLine("Thương: " + (a / b));
        // Console.WriteLine("Dư: " + (a % b));
        // bool isAdult = a > 18;
        // Console.WriteLine("Có phải là người lớn: " + isAdult);

        // Bài tập 1 -> in ra câu: Tên tôi là [name], năm nay tôi [age] tuổi, học sinh ? [isStudent]
        // string name = "Tâm";
        // int age = 16;
        // bool isStudent = age < 18;
        // Console.WriteLine($"Tên tôi là {name}, năm nay tôi {age} tuổi, học sinh ? {isStudent}");

        // Bài tập 2: Nhập 2 số nguyên từ bàn phím (Console.ReadLine) → in ra tổng, hiệu, tích, thương, dư.
        // Console.Write("Nhập số thứ nhất: ");
        // int soThuNhat = int.Parse(Console.ReadLine().ToString());
        // Console.Write("Nhập số thứ hai: ");
        // int soThuHai = int.Parse(Console.ReadLine().ToString());
        // Console.WriteLine("Tổng: " + (soThuNhat + soThuHai));
        // Console.WriteLine("Hiệu: " + (soThuNhat - soThuHai));
        // Console.WriteLine("Tích: " + (soThuNhat * soThuHai));
        // Console.WriteLine("Thương: " + (soThuNhat / soThuHai));
        // Console.WriteLine("Dư: " + (soThuNhat % soThuHai));

        // Bài tập 3: Nhập tuổi từ bàn phím → kiểm tra xem có đủ 18 tuổi không (>= 18) → in kết quả True/False.
        // Console.Write("Nhập tuổi: ");
        // bool isOver18 = int.Parse(Console.ReadLine().ToString()) >= 18;
        // Console.WriteLine($"kiểm tra đủ 18 tuổi? {isOver18}");


        // Bài tập 4: Viết một chương trình nhỏ kiểm tra số chẵn/lẻ:
        // Console.Write("Nhập số: ");
        // int number = Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine(number % 2 == 0 ? "Chẵn" : "Lẻ"); // -> cách 1 
        // bool isEven = Convert.ToInt32(Console.ReadLine()) % 2 == 0 ? true : false; //-> cách 2
        // Console.WriteLine($"Đây là số chẵn: {isEven}");

        // Bài 2: Biến và kiểm dữ liệu
        // khai báo biến
        // int age = 25;
        // double height = 1.75;
        // string name = "Cybersoft";
        // bool isActive = true;
        // Console.WriteLine($"Thông tin tài khoản người dùng tên: {name}, cao: {height}, tuổi: {age}, trạng thái {isActive}");
        // Console.Write("Cập nhật lại tuổi: ");
        // age = int.Parse(Console.ReadLine());
        // Console.Write("Cập nhật lại chiều cao: ");
        // height = double.Parse(Console.ReadLine());
        // Console.WriteLine("Thông tin đã được cập nhật thành công!");
        // Console.WriteLine($"Thông tin tài khoản người dùng tên: {name}, cao: {height}, tuổi: {age}, trạng thái {isActive}");

        // BÀI 3: TOÁN TỬ VÀ TÍNH TOÁN
        //Thực hành với toán tử số học +, -, *, /, %
        // Hiểu về ép kiểu ngầm định và tường minh
        // Console.WriteLine("=== TÍNH TOÁN CƠ BẢN ===");
        // Console.Write("Nhập số a: ");
        // int a = Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine("Nhập số b: ");
        // int b = Convert.ToInt32(Console.ReadLine());
        // // Tính toán
        // int sum = a + b;
        // int difference = a - b;
        // int product = a * b;
        // double quotient = (double)a / b; // ép kiểm để có kết quả thập phân -> ép kiểm tường minh
        // phân biệt ép kiểm ngầm định và tường minh: ngầm định là gán kiểu biến thấp đến cao (Kiểu nhỏ → kiểu lớn) int → long → float → double. 
        // Ngược lại phải khai báo định dạng lại cho từ cao xuống thấp (tường minh) (Kiểu lớn → kiểu nhỏ) sử dụng dấu (kiểm dữ liệu) để thực hiện
        // int remainder = a % b;
        // Console.WriteLine($"Tổng: {a} + {b} = {sum}");
        // Console.WriteLine($"Hiệu: {a} - {b} = {difference}");
        // Console.WriteLine($"Tích: {a} * {b} = {product}");
        // Console.WriteLine($"Thương: {a} / {b} = {quotient:F2}");
        // Console.WriteLine($"Phần dư: {a} % {b} = {remainder}");

        // BÀI 4: ỨNG DỤNG THỰC TẾ - CHUYỂN ĐỔI NHIỆT ĐỘ
        // Áp dụng kiến thức vào bài toán thực tế
        // Luyện tập nhập xuất và tính toán
        // Console.WriteLine("=== CHUYỂN ĐỔI NHIỆT ĐỘ C → F ===");
        // Console.Write("Nhập nhiệt độ (Celsius): ");
        // double celsius = Convert.ToDouble(Console.ReadLine());
        // double fahrenheit = (celsius * 9 / 5) + 32;
        // Console.WriteLine($"{celsius}°C = {fahrenheit}°F");
        // Console.WriteLine($"Làm tròn: {celsius}°C = {Math.Round(fahrenheit, 1)}°F");

        // BÀI 5: TÍNH CHU VI VÀ DIỆN TÍCH HÌNH TRÒN
        // const double PI = 3.14159; // khai báo biến là hằng số

        // Console.WriteLine("=== TÍNH HÌNH TRÒN ===");
        // Console.Write("Nhập bán kính (r): ");
        // double radius = Convert.ToDouble(Console.ReadLine());

        // double perimeter = 2 * PI * radius;
        // double area = PI * Math.Pow(radius, 2);

        // Console.WriteLine($"Chu vi: {perimeter:F2}");
        // Console.WriteLine($"Diện tích: {area:F2}");


        // BÀI 6: TÍNH CHỈ SỐ BMI
        Console.WriteLine("=== TÍNH CHỈ SỐ BMI ===");
        Console.Write("Nhập cân nặng (kg): ");
        double weight = Convert.ToDouble(Console.ReadLine());
        Console.Write("Nhập chiều cao (m): ");
        double height = Convert.ToDouble(Console.ReadLine());
        double bmi = weight / (height * height);
        Console.WriteLine($"Chỉ số BMI: {bmi:F1}");
        // Phân loại BMI
        if (bmi < 18.5)
            Console.WriteLine("Phân loại: Gầy");
        else if (bmi < 24.9)
            Console.WriteLine("Phân loại: Bình thường");
        else if (bmi < 29.9)
            Console.WriteLine("Phân loại: Tiền béo phì");
        else
            Console.WriteLine("Phân loại: Béo phì");


    }
}