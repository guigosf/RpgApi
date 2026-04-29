BEGIN TRANSACTION;
ALTER TABLE [TB_PERSONAGENS] ADD [FotoPersonagem] varbinary(max) NULL;

ALTER TABLE [TB_PERSONAGENS] ADD [UsuarioId] int NULL;

CREATE TABLE [TB_USUARIOS] (
    [Id] int NOT NULL IDENTITY,
    [Usernme] varchar(200) NOT NULL,
    [PasswordHash] varbinary(max) NULL,
    [PasswordSalt] varbinary(max) NULL,
    [Foto] varbinary(max) NULL,
    [latitude] float NULL,
    [longitude] float NULL,
    [DataAcesso] datetime2 NULL,
    [Perfil] varchar(200) NULL DEFAULT 'Jogador',
    [Email] varchar(200) NULL,
    CONSTRAINT [PK_TB_USUARIOS] PRIMARY KEY ([Id])
);

UPDATE [TB_PERSONAGENS] SET [FotoPersonagem] = NULL, [UsuarioId] = 1
WHERE [Id] = 1;
SELECT @@ROWCOUNT;


UPDATE [TB_PERSONAGENS] SET [FotoPersonagem] = NULL, [UsuarioId] = 1
WHERE [Id] = 2;
SELECT @@ROWCOUNT;


UPDATE [TB_PERSONAGENS] SET [FotoPersonagem] = NULL, [UsuarioId] = 1
WHERE [Id] = 3;
SELECT @@ROWCOUNT;


UPDATE [TB_PERSONAGENS] SET [FotoPersonagem] = NULL, [UsuarioId] = 1
WHERE [Id] = 4;
SELECT @@ROWCOUNT;


UPDATE [TB_PERSONAGENS] SET [FotoPersonagem] = NULL, [UsuarioId] = 1
WHERE [Id] = 5;
SELECT @@ROWCOUNT;


UPDATE [TB_PERSONAGENS] SET [FotoPersonagem] = NULL, [UsuarioId] = 1
WHERE [Id] = 6;
SELECT @@ROWCOUNT;


UPDATE [TB_PERSONAGENS] SET [FotoPersonagem] = NULL, [UsuarioId] = 1
WHERE [Id] = 7;
SELECT @@ROWCOUNT;


IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'DataAcesso', N'Email', N'Foto', N'PasswordHash', N'PasswordSalt', N'Perfil', N'Usernme', N'latitude', N'longitude') AND [object_id] = OBJECT_ID(N'[TB_USUARIOS]'))
    SET IDENTITY_INSERT [TB_USUARIOS] ON;
INSERT INTO [TB_USUARIOS] ([Id], [DataAcesso], [Email], [Foto], [PasswordHash], [PasswordSalt], [Perfil], [Usernme], [latitude], [longitude])
VALUES (1, NULL, 'seuEmail@gmail.com', NULL, 0x184DBF3FC41A0210545E0B6DC2FF4191CBAAC1ED58CF0B3003B66371FEC7DB4B92B42CA849F617348EFA15E6490A3F15B57F3ED433C1386FF40AE091456D0D9D, 0xC8C74BA428C3A34F09719A65DB5C848630F8E319DED2DFE5ED09F0F2294A9672608F23C5ABA467B3B1F160FB4E1D692B5D5DA681942EB214586DFD63CEFE1B3C0CF314F0FC5287D9399F14F8168D1EF4C9DBBB1FC056794AFBA68D8462CCAD86EA7CA742B4277D4FD4B73C7C43F3B50A035B3E4067DB012E531FFA5A9FA96E66, 'Admin', 'UsuarioAdmin', -23.520024100000001E0, -46.596497999999997E0);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'DataAcesso', N'Email', N'Foto', N'PasswordHash', N'PasswordSalt', N'Perfil', N'Usernme', N'latitude', N'longitude') AND [object_id] = OBJECT_ID(N'[TB_USUARIOS]'))
    SET IDENTITY_INSERT [TB_USUARIOS] OFF;

CREATE INDEX [IX_TB_PERSONAGENS_UsuarioId] ON [TB_PERSONAGENS] ([UsuarioId]);

ALTER TABLE [TB_PERSONAGENS] ADD CONSTRAINT [FK_TB_PERSONAGENS_TB_USUARIOS_UsuarioId] FOREIGN KEY ([UsuarioId]) REFERENCES [TB_USUARIOS] ([Id]);

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20260429011819_MigracaoUsuario', N'10.0.5');

COMMIT;
GO

