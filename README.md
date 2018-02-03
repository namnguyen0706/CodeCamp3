Thực Hành:
Bài 1: Có 1 mảng dữ liệu dưới đây, sắp xếp danh sách thành phố theo độ dài sau đó xếp theo thứ tự A-Z:
// mảng dữ liệu ban đầu
string[] cities =  
{  
    "ROME","ZURICH","AMSTERDAM","SAIGON", "LONDON","HANOI","CALIFORNIA", "PARIS"  
};  
// in ra kết quả thứ tự
ROME 
HANOI
PARIS
LONDON
SAIGON
ZURICH
AMSTERDAM
CALIFORNIA
Bài 2: Viết 1 phương thức kiểm tra 2 tập hợp dữ liệu: sử dụng LINQ không dùng vòng lặp
// Phương thức dưới đây trả về True khi tất cả các phần tử trong tập hợp squares
// bằng với bình phương của các phần tử trong tập hợp numbers
/* Ví dụ Test cases:
TestForSquares({1, 2, 3, 4, 5}, {1, 4, 9, 16, 25}) -> True
TestForSquares({1, 2, 5}, {1, 4, 9}) -> False
TestForSquares({}, {}) -> True
TestForSquares({1, 5, 3}, {1, 25, 9, 9}) -> False
*/
public static bool TestForSquares(IEnumerable<int> numbers, IEnumerable<int> squares)
{
    return //....;
}
Bài 3: Viết 1 phương thức kiểm tra tập hợp dữ liệu: sử dụng LINQ không dùng vòng lặp
// Cho 1 tập hợp các chuỗi, lọc sao chỉ còn các phần tử có kí tự 'e',
// sau đó sắp xếp các từ theo thứ tự chữ cái A->Z, rồi trả về kết quả như sau
// trả về 1 câu như sau với <word> là từ cuối cùng trong tập hợp đã đc sắp xếp ở trên:
//  "The last word is <word>"
// Nếu không có phần tử nào chứa 'e', thì trả về null.
/* Ví dụ Test cases:
GetTheLastWord({he,she,it,we,you,they}) -> The last word is we
GetTheLastWord({hop,top,stop,cop,lop,chop}) -> null
 GetTheLastWord({hieu,em,anh,con,phep,tet}) -> The last word is tet
*/
public static string GetTheLastWord(IEnumerable<string> words)
{
    return ;