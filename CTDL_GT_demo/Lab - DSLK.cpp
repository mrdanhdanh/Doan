/*Lab Danh sách liên kết đơn
Họ Tên  :
MSSV    :
*/
#include <iostream>
#include <string>

using namespace std;

struct Node
{
	int data;
	Node* pNext;
};

/* Yêu cầu 1. Khởi tạo một NODE trong DSLK đơn từ một số nguyên k */
Node* CreateNode(int k)
{
	Node* p = new Node; 
	
	/*Sinh viên tự hoàn thành đoạn code này*/
	...

	return p;
}

/* Yêu cầu 2. Thêm số nguyên k vào đầu DSLK đơn */
void InsertFirst(Node*& pHead, int k)
{
	Node* p = CreateNode(k);	//Tạo NODE p từ số nguyên k
	
	/*Sinh viên tự hoàn thành đoạn code này*/
	...
}

/* Yêu cầu 3. Thêm số nguyên k vào cuối DSLK đơn */
void InsertLast(Node*& pHead, int k)
{
	Node* p = CreateNode(k);	//Tạo NODE p từ số nguyên k
	
	/*Sinh viên tự hoàn thành đoạn code này*/
	...
}

/* Yêu cầu 4. In toàn bộ số nguyên trong DSLK đơn */
void PrintList(Node* pHead)
{
	/*Sinh viên tự hoàn thành đoạn code này*/
	...
}

/* Yêu cầu 5. Tìm kiếm số nguyên k trong DSLK đơn. Nếu có trả về true. Ngược lại trả về false */
bool SearchList(Node* pHead, int k)
{
	bool result = false;

	/*Sinh viên tự hoàn thành đoạn code này*/
	...

	return result;
}

/* Yêu cầu 6. Hoàn thành hàm main() theo yêu cầu */
int main()
{
	Node* pHead = NULL;
	int k;
	do
	{
		cout << "Nhap gia tri cua Node (Nhap -1 de ngung thao tac): ";
		cin >> k;		
		if (k != -1)
		{
			/*Thêm k vào CUỐI DSLK đơn - Sinh viên tự hoàn thành đoạn code này*/
			...	
		}		
	} while (input != -1);

	
	/*In toàn bộ số nguyên trong DSLK đơn - Sinh viên tự hoàn thành đoạn code này*/
	...
	

	/*Nhập vào số nguyên k và kiểm tra k có trong DSLK đơn không - Sinh viên tự hoàn thành đoạn code này*/	
	...

	return 0;
}



