#include <iostream>

int main() {
    // Declaramos un arreglo de 5 enteros
    int numeros[5] = {10, 20, 30, 40, 50};

    // Mostramos los elementos del arreglo
    std::cout << "Elementos del arreglo:" << std::endl;
    for (int i = 0; i < 5; i++) {
        std::cout << "numeros[" << i << "] = " << numeros[i] << std::endl;
    }

    return 0;
}