use Cosiness
Update dbo.Images
set Bytes = (SELECT * FROM   OPENROWSET(BULK 'C:\�����.jpg',SINGLE_BLOB) AS image),
ImagePath = 'C:\�����.jpg'
where Image_ID = '1';
--INSERT INTO dbo.Images
--           ([Bytes],[ImagePath])
--VALUES     ((SELECT * FROM   OPENROWSET(BULK 'C:\TEST.png',SINGLE_BLOB) AS image), 'C:\TEST.png');
GO