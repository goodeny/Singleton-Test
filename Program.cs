using System;

public class Singleton {
    private static Singleton instance;

    private Singleton (){
        
    }
    
    public static Singleton Instance {
        get{
            if (instance == null){
                instance = new Singleton();
            }
            return instance;
        }
    }
    
    public void Menu(){
        Console.WriteLine(@"
        _____           _____  _____   ______            ______          _____     ____             ______   
        ___|\    \     ____|\    \|\    \ |\     \       ___|\     \    ____|\    \   |    |        ___|\     \  
         /    /\    \   /     /\    \\\    \| \     \     |    |\     \  /     /\    \  |    |       |     \     \ 
        |    |  |    | /     /  \    \\|    \  \     |    |    |/____/| /     /  \    \ |    |       |     ,_____/|
        |    |  |____||     |    |    ||     \  |    | ___|    \|   | ||     |    |    ||    |  ____ |     \--'\_|/
        |    |   ____ |     |    |    ||      \ |    ||    \    \___|/ |     |    |    ||    | |    ||     /___/|  
        |    |  |    ||\     \  /    /||    |\ \|    ||    |\     \    |\     \  /    /||    | |    ||     \____|\ 
        |\ ___\/    /|| \_____\/____/ ||____||\_____/||\ ___\|_____|   | \_____\/____/ ||____|/____/||____ '     /|
        | |   /____/ | \ |    ||    | /|    |/ \|   ||| |    |     |    \ |    ||    | /|    |     |||    /_____/ |
         \|___|    | /  \|____||____|/ |____|   |___|/ \|____|_____|     \|____||____|/ |____|_____|/|____|     | /
           \( |____|/      \(    )/      \(       )/      \(    )/          \(    )/      \(    )/     \( |_____|/ 
            '   )/          '    '        '       '        '    '            '    '        '    '       '    )/    
                '                                                                                            '     
        [1] Mostrar Dados\n[2] Inserir Dados\n[3] Atualizar Dados\n[4] Deletar Dados
        ");
        string c = Console.ReadLine();
        switch(Convert.ToInt16(c)){
            case 1:
                Console.WriteLine("Mostrando dados");
            break;
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Singleton.Instance.Menu();
        
    }
}
