CREATE TABLE Jacarei_Acervo (
    AcervoId INT PRIMARY KEY,
    -- Outras colunas específicas do Jacarei_Acervo
);

CREATE TABLE Setor (
    SetorId INT PRIMARY KEY,
    AcervoId INT,
    -- Outras colunas específicas do Setor
    FOREIGN KEY (AcervoId) REFERENCES Jacarei_Acervo(AcervoId)
);

CREATE TABLE Colecoes (
    ColecaoId INT PRIMARY KEY,
    SetorId INT,
    -- Outras colunas específicas do Colecoes
    FOREIGN KEY (SetorId) REFERENCES Setor(SetorId)
);

CREATE TABLE Objetos (
    ObjetoId INT PRIMARY KEY,
    ColecaoId INT,
    -- Outras colunas específicas do Objetos
    FOREIGN KEY (ColecaoId) REFERENCES Colecoes(ColecaoId)
);
