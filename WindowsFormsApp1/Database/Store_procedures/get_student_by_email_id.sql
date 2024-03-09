DROP PROCEDURE IF EXISTS get_student_by_email_id
DELIMITER $$
CREATE PROCEDURE get_student_by_email_id(
  email_id VARCHAR(45)
)
BEGIN
	SELECT * 
    FROM  student_info si
		JOIN users u USING(prn_number)
		WHERE u.email_id = email_id;
END $$
DELIMITER ;