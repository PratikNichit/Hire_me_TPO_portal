DROP FUNCTION IF EXISTS check_if_user_exists;
DELIMITER $$
CREATE FUNCTION check_if_user_exists(
	email_id VARCHAR(45),
    password VARCHAR(45)
)
RETURNS VARCHAR(10)
READS SQL DATA
BEGIN
	DECLARE status VARCHAR(10) DEFAULT 'FALSE';
    DECLARE stored_email_id VARCHAR(45);
    DECLARE stored_password VARCHAR(45);
    
    SELECT email_id,password INTO stored_email_id,stored_password
    FROM users u
    WHERE u.email_id = email_id AND u.password = password;
    
    IF stored_email_id IS NOT NULL AND stored_password IS NOT NULL THEN
		SELECT 'TRUE' INTO status;
	END IF;
RETURN status;
END $$ 
DELIMITER ;