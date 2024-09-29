Dictionary<int, Employee> employees = new Dictionary<int, Employee>();
employees.Add(100, new Employee() { FirstName = "Joao", LastName = "Silva", PhoneNumber = "49 993345-5566" });
employees.Add(210, new Employee() { FirstName = "Alexandre", LastName = "Souza", PhoneNumber = "49 992344-7892" });
employees.Add(303, new Employee() { FirstName = "Jemiro", LastName = "Sandri", PhoneNumber = "49 993458-0736" });

bool isCorrect;

do
{
    Console.Write("Insira o identificador do funcionário: ");
    string idString = Console.ReadLine();
    
    // Verifica se o valor inserido é um número inteiro
    isCorrect = int.TryParse(idString, out int id);
    
    if (isCorrect)
    {
        Console.ForegroundColor = ConsoleColor.White;
        
        // Verifica se o identificador existe no dicionário
        if (employees.TryGetValue(id, out Employee employee))
        {
            Console.WriteLine(
                $"Primeiro nome: {employee.FirstName}{Environment.NewLine}" +
                $"Segundo nome: {employee.LastName}{Environment.NewLine}" +
                $"Número de telefone: {employee.PhoneNumber}"
            );
        }
        else
        {
            Console.WriteLine("O funcionário com o identificador fornecido não existe.");
        }
        
        Console.ForegroundColor = ConsoleColor.Gray;
    }
    else
    {
        // Mensagem caso a entrada não seja válida
        Console.WriteLine("Entrada inválida. Insira um identificador de funcionário válido.");
    }

} while (isCorrect);

