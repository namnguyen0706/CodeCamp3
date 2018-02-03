Câu 1: Lớp trong C# có thể kế thừa nhiều Interface (B)

Câu 2: Đoạn code dưới biến result sẽ có giá trị là gì?
int grade = 65;
string result = grade > 50 ? "Passed" : "Failed";
gia tri la: "Passed"
Câu 3. Mảng trong C# bắt đầu bằng index 0 (C)

Câu 4. Điều nào dưới đây là đúng? dap an A,D
A. Đoạn code trong finally được thực hiện trong mọi trường hợp
D. Đoạn code finally có thể trả về kết quả với return

Câu 5. Cách để lớp Dog kế thừa từ lớp Animal
D. class Dog : Animal {...}

Câu 6. Trong lớp Animal, đâu là hàm khởi tạo hay constructor
C. public Animal () {}

Câu 7. Đoạn code dưới đây trả về kết quả gì
   class test
   {
       public void print()
       {
           Console.WriteLine("Csharp");
       }
   }
   class Program
   {
       static void Main(string[] args)
       {
           test t;
           t.print();
       }
   }

   C. Gặp lỗi vì biến t

   Câu 8. Có 1 file myDoc.txt, làm sao để đọc thời gian file này được tạo trong C#
   A.

FileInfo myDoc = new FileInfo(@"C:\Users\Admin\Desktop\myDoc.txt");
Console.WriteLine(myDoc.CreationTime);

Câu 9. Đoạn code dưới đây trả về kết quả gì?
List<int> numbers = new List<int>() {100, 7, 23, 4, 9, 0};
var a = numbers.Find(item => item%2 == 0);
foreach (var item in a){
    Console.Write(item);
    Console.Write(" ");
}
B. 100 4 0

Câu 10. Đoạn code dưới đây trả về kết quả gì?
colors.Max (c => c.Length)
A. 5

Câu 11. Biến query trong đoạn code dưới đây có kiểu dữ liệu là gì?
var query = from c in colors where c.Length > 3 orderby c.Length select c;
c. IQueryable

Câu 12. Đoạn code dưới đây trả về kết quả gì?
var query = from c in colors where c.Length == colors.Max (c2 => c2.Length) select c;

foreach (var element in query)
  Console.WriteLine (element);

A. green brown


Câu 13. Đoạn code dưới đây trả về kết quả gì?
var query = colors.Where (c => c.Contains ("e")).Where (c => c.Contains ("n"));

Console.WriteLine (query.Count());
A. 1




Câu 14. Khi kế thừa, lớp con trong cùng 1 assembly có thể kế thừa những thành viên nào của lớp cha
B. public, protected, internal

Câu 15. Đoạn code dưới đây trả về kết quả gì?
List<double> doubles = new List<double> { 2.0, 2.1, 2.2, 2.3 };
double whatsThis = doubles.FirstOrDefault(val => val > 2.3);
A. Giá trị mặc định cho double là 0.0d

Câu 16. Biến result sẽ gồm những số nào?
List<int> ints = new List<int> { 1, 2, 4, 8, 4, 2, 1 };
List<int> filter = new List<int> { 1, 1, 2, 3, 5, 8 };
// Will contain { 1, 2, 8 }
IEnumerable<int> result = ints.Intersect(filter);
A. 1 2 8


