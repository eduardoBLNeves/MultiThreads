new Thread(() => { FazTarefa("Lavar Louça", 3000); }).Start();
new Thread(() => { FazTarefa("Lavar Roupa", 3000); }).Start();
new Thread(() => { FazTarefa("Fazer Almoço", 1000); }).Start();


void FazTarefa(string nomeTarefa, int tempo)
{
    Console.WriteLine("Inicio:" +nomeTarefa);
    Thread.Sleep(tempo);
    Console.WriteLine("Fim:" +nomeTarefa);
}



// LavarRoupa();
// LavarLouca();
// FazerAlmoço();

//void LavarRoupa()
//{
//    Console.WriteLine("Inicio: Lavar Roupa");
//    Thread.Sleep(3000);
//    Console.WriteLine("Fim: Lavar Roupa");
//}
//void LavarLouca()
//{
//    Console.WriteLine("Inicio: Lavar Louça");
//    Thread.Sleep(3000);
//    Console.WriteLine("Fim: Lavar Louça");
//}
//void FazerAlmoço()
//{
//    Console.WriteLine("Inicio: Fazer Almoço");
//    Thread.Sleep(1000);
//    Console.WriteLine("Fim: Fazer Almoço");
//}