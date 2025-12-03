#include <iostream>

struct base
{
   ~base() 
    { delete [] mData; }
    base():mSize(0),mData(nullptr)
    {}
    base(const size_t size):mSize(size),mData(new int[size])
    {}
    base(const base& rhs):mSize(rhs.mSize),mData(new int[mSize])//Конструктор копирования
    {}
    size_t mSize;
    int*   mData;
};

struct der: base
{
    der():mValue(0)
    {}
    der(const size_t size, const int value = 0):base(size),mValue(value)
    {}
    der(const der& rhs):mValue(rhs.mValue)//Здесь будет запущен конструктор base() но не base(const base& rhs)!
    {}
    //Правильно так: der(const der& rhs):base(rhs),mValue(rhs.mValue)
    void view()const
    {
        std::cout << "value = "
                  << mValue
                  << " : size = "
                  << mSize
                  <<'\n';
    }
    int mValue;
};

int main()
{
    der d1(10,10);
    d1.view();     //value = 10 : size = 10
    der d2(d1);
    d2.view();     //value = 10 : size = 0
}