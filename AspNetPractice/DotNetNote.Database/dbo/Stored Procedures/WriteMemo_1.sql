
--메모 입력용 저장 프로시저
Create Procedure dbo.WriteMemo
(
	@Name NVarChar(25),
	@Email NVarChar(100),
	@Title NVarChar(150),
	@PostIP NVarChar(15)
)
As
	Insert Memos(Name, Email, Title, PostIP)
	Values(@Name, @Email, @Title, @PostIP)
