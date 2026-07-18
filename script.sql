IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'TesteConexao')
    BEGIN
        CREATE TABLE TesteConexao (
            Id INT IDENTITY(1, 1) PRIMARY KEY,
            Mensagem VARCHAR(100),
            DataEnvio DATETIME DEFAULT GETDATE()
        );
            INSERT INTO TesteConexao (Mensagem) VALUES ('Conexão via GitHub Actions realizada com sucesso!');
        END