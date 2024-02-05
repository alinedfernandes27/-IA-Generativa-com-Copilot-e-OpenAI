#include <stdio.h>
#include <unistd.h>

int main() {
    printf("Iniciando a viagem no tempo...\n");
    for(int i = 10; i >= 0; i--) {
        printf("%d\n", i);
        sleep(1); // pausa por 1 segundo
    }
    printf("Você viajou no tempo!\n");
    return 0;
}
