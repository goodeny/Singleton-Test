# Singleton-Test

## private static Singleton instance;
Instancia unica e privada da classe

## private Singleton() { }
Construtor privado pra não ser instanciada diretamente fora da classe Singleton

## public static Singleton Instance
Propriedade publica que retorna o objeto Singleton, é por ela que acessa fora da classe. ex: Singleton.Instance.Menu(); 

## get
Acessador de propriedades que permite obter o valor de Instance, quando acessar <Singleton.Instance> essa parte do codigo é executada
