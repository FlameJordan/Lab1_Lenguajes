After running the project, be created a database named nearlinx_time_tracker_db and is necessary to execute to following SQLscript.
```sh
-- clear tables
DELETE FROM RoleUser;
DELETE FROM Roles;
DELETE FROM Users;
-- create initial data
DECLARE @userId UNIQUEIDENTIFIER = NEWID();
DECLARE @autenticatedUserRoleId UNIQUEIDENTIFIER = NEWID();
DECLARE @userManagementRoleId UNIQUEIDENTIFIER = NEWID();
DECLARE @roleManagementRoleId UNIQUEIDENTIFIER = NEWID();
DECLARE @companyManagementRoleId UNIQUEIDENTIFIER = NEWID();
DECLARE @projectManagementRoleId UNIQUEIDENTIFIER = NEWID();
DECLARE @rateManagementRoleId UNIQUEIDENTIFIER = NEWID();
INSERT INTO Users VALUES -- jdoe / 1234
(@userId,'jdoe','03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4',GETDATE(),GETDATE(),'John','Doe','jdoe@nearlinx.com',0);
INSERT INTO Roles VALUES
(@autenticatedUserRoleId,'AuthenticatedUser','this is an example of role for test in the back end and front end',0),
(@userManagementRoleId,'UserManagement','Allows user management',0),
(@roleManagementRoleId,'RoleManagement','Allows role management',0),
(@companyManagementRoleId,'CompanyManagement','Allows company management',0),
(@projectManagementRoleId,'ProjectManagement','Allows project management',0),
(@rateManagementRoleId,'RateManagement','Allows rate management',0)
;
INSERT INTO RoleUser VALUES
(@autenticatedUserRoleId,@userId),
(@userManagementRoleId,@userId),
(@roleManagementRoleId,@userId),
(@companyManagementRoleId,@userId),
(@projectManagementRoleId,@userId),
(@rateManagementRoleId,@userId)
;
```
