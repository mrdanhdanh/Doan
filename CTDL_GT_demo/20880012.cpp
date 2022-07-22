/*Lab Struct:
Họ Tên  : Nguyễn Hữu Danh
MSSV    : 20880012
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
	p->data = k;
	p->pNext = NULL;

	return p;
}

/* Yêu cầu 2. Thêm số nguyên k vào đầu DSLK đơn */
void InsertFirst(Node*& pHead, int k)
{
	Node* p = CreateNode(k);	//Tạo NODE p từ số nguyên k

	/*Sinh viên tự hoàn thành đoạn code này*/
	if (pHead == NULL) {
		pHead = p;
	}
	else {
		p->pNext = pHead;
		pHead = p;
	}
	//Nếu DSLK rỗng -> pHead là NULL -> pHead = pNew
}

/* Yêu cầu 3. Thêm số nguyên k vào cuối DSLK đơn */
void InsertLast(Node*& pHead, int k)
{
	Node* p = CreateNode(k);	//Tạo NODE p từ số nguyên k

	/*Sinh viên tự hoàn thành đoạn code này*/
	if (pHead == NULL) {
		pHead = p;
	}
	else {
		Node* pCurrent = pHead;
		while (pCurrent->pNext != NULL) {
			pCurrent = pCurrent->pNext;
		}
		pCurrent->pNext = p;
	}
}

/* Yêu cầu 4. In toàn bộ số nguyên trong DSLK đơn */
void PrintList(Node* pHead)
{
	/*Sinh viên tự hoàn thành đoạn code này*/
	if (pHead == NULL) {
		cout << "Danh Sach Rong!!!";
	}
	else {
		while (pHead != NULL) {
			cout << pHead->data << " ";
			pHead = pHead->pNext;
		}
	}
	cout << endl;
}

/* Yêu cầu 5. Tìm kiếm số nguyên k trong DSLK đơn. Nếu có trả về true. Ngược lại trả về false */
bool SearchList(Node* pHead, int k)
{
	/*Sinh viên tự hoàn thành đoạn code này*/
	if (pHead == NULL) {
		cout << "Danh Sach Rong, Khong The Tim Kiem";
	}
	else {
		while (pHead != NULL) {
			if (pHead->data == k) {
				return true;
			}
			pHead = pHead->pNext;
		}
	}
	return false;
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
			InsertLast(pHead, k);
		}
	} while (k != -1);


	/*In toàn bộ số nguyên trong DSLK đơn - Sinh viên tự hoàn thành đoạn code này*/
	PrintList(pHead);


	/*Nhập vào số nguyên k và kiểm tra k có trong DSLK đơn không - Sinh viên tự hoàn thành đoạn code này*/
	cout << "Nhap so can tim:  ";
	cin >> k;

	if (SearchList(pHead, k))
		cout << "So nguyen k co ton tai trong DSLK" << endl;
	else
		cout << "So nguyen k khong ton tai trong DSLK" << endl;
	return 0;
}