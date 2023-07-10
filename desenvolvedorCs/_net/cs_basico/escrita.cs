    StreamWriter sw = new StreamWriter(EnderecoArquivo, false);
                foreach (Contato contato in contatoList)
                {
                    string linha = string.Format("{0};{1};{2}", contato.Nome, contato.Email, contato.NumeroTelefone);
                    sw.WriteLine(linha);
                }
                sw.Flush();
                sw.Close();