//#include <clocale>
#include <cstdlib>
#include <ctime>
#include <iostream>
 
/// заполнение матрицы случайными числами из диапазона [0, 99]
void FillRandomNumbers(int **matrix, const size_t rows, const size_t columns) {
    srand(time(0)); // инициализируем ПГСЧ

    for (size_t row = 0; row < rows; row++)
        for (size_t column = 0; column < columns; column++)
            matrix[row][column] = rand() % 100; // присваиваем СЧ
}
 
/// вывод матрицы на экран
void Print(int **matrix, const size_t rows, const size_t columns) {
    for (size_t row = 0; row < rows; row++) {
        for (size_t column = 0; column < columns; column++)
            std::cout << matrix[row][column] << " "; // выводим элемент
        std::cout << std::endl; // перевод строки
    }
}
 
/// пример обработки матрицы - подсчет суммы всех элементов
int Sum(int **matrix, const size_t rows, const size_t columns) {
    int sum = 0; // счётчик суммы
    for (size_t row = 0; row < rows; row++)
        for (size_t column = 0; column < columns; column++)
            sum += matrix[row][column];
 
    return sum; // вернуть результат
}
 
// ...
// сюда вставить все дополнительные функции которые напишете
// ...
 
 
int main() {
    //setlocale(LC_ALL, "rus"); // установим локаль для вывода русских символов
 
    size_t rows, columns; // строки и столбцы
 
    // вводим размерность матрицы
    std::cout << "Введите количество строк матрицы: ";
    std::cin >> rows;
    std::cout << "Введите количество столбцов матрицы: ";
    std::cin >> columns;
 
    // выделяем память под матрицу
    int **matrix = new int*[rows];
    for (size_t row = 0; row < rows; row++)
        matrix[row] = new int[columns];
 
    // заполнение случайными числами
    FillRandomNumbers(matrix, rows, columns);
 
    // вывод на экран
    std::cout << "\nМатрица:\n";
    Print(matrix, rows, columns);
 
    // обработка матрицы
    std::cout << "\nСумма всех элементов матрицы равна " << Sum(matrix, rows, columns) << std::endl;
 
    // освобождаем память, выделенную под матрицу
    // освобождение идёт в обратном порядке от выделения
    for (size_t row = 0; row < rows; row++)
        delete[] matrix[row];
    delete[] matrix;
 
    // ждём нажатия клавиши перед выходом из приложения
    //system("pause");
}