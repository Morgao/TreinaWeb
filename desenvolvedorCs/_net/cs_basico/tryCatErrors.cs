try
{
      if (File.Exists(@"C:\teste.txt"))
      {
            StreamReader stream = new StreamReader(@"C:\teste.txt");
            string linha;
            while((linha = stream.ReadLine()) != null)
            {
                  // Tratamento da linha lida do arquivo texto
            }
      }
      else
      {
            MessageBox.Show("O arquivo não existe na unidade C");
      }
}
catch (IOException)
{
      MessageBox.Show("O arquivo não está acessível.");
}
catch (OutOfMemoryException)
{
      MessageBox.Show("Sem memória para criação do buffer");
}
catch (Exception ex)
{
      MessageBox.Show("Erro desconhecido: " + ex.Message);
}