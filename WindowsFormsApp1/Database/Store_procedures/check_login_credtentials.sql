DROP PROCEDURE IF EXISTS check_login_info;
DELIMITER $$
CREATE PROCEDURE check_login_credtentials(
  email_id VARCHAR(45),
  password VARCHAR(45)
)
BEGIN
	SELECT check_if_user_exists(email_id,password);
END $$
DELIMITER ;


