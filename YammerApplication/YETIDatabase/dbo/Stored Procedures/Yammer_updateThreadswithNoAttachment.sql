﻿CREATE PROCEDURE Yammer_updateThreadswithNoAttachment (@NEW_STATUS NVARCHAR(100),
@PREV_STATUS NVARCHAR(100),
@PROCESSEDBY NVARCHAR(100))
AS
BEGIN
	UPDATE YM_MESSAGES SET PROCESS_STATUS = @NEW_STATUS WHERE PROCESSED_BY = @PROCESSEDBY AND PROCESS_STATUS = @PREV_STATUS	
	UPDATE YM_ExportDetails SET Status = @NEW_STATUS WHERE Status = @PREV_STATUS AND FileName IN 
	(SELECT DISTINCT csvfilename FROM YM_Messages WHERE PROCESSED_BY = @PROCESSEDBY AND PROCESS_STATUS = @NEW_STATUS)
END
