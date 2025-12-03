#include <fstream>
#include <iostream>

int main()
{
    std::ofstream out("int.dat",std::ios::binary);
    for (int i=0;i<10;i++)
    {
        out.write(reinterpret_cast<char*>(&i), sizeof(int));
        std::cout<<i<<" ";
    }
    out.close();
    std::cout<<std::endl<<"File:"<<std::endl;
    std::ifstream in("int.dat",std::ios::binary);
    while (in)
    {
        int t;
        in.read(reinterpret_cast<char*>(&t), sizeof(int));
        if (!in) break;
        std::cout<<t<<" ";
    }
    in.close();
}