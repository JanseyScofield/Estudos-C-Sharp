namespace ExerciciosPropostosP8 {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Digite o tamanho da matriz no formato (x,x): ");
            int tamanho = int.Parse(Console.ReadLine());

            int[,] matriz = new int[tamanho, tamanho];
            
            for(int iCont = 0;iCont < 3; iCont++) {
                for (int jCont = 0; jCont < 3; jCont++) {
                    Console.Write($"Digite o valor ({iCont},{jCont}): ");
                    matriz[iCont, jCont] = int.Parse(Console.ReadLine());
                }
            }
            for(int iCont = 0; iCont < 3; iCont++) {
                for(int jCont = 0;jCont < 3; jCont++) {
                    if(iCont == jCont) {
                        Console.Write(matriz[iCont,jCont] + " ");
                    }
                }
                
            }
        }
    }
}