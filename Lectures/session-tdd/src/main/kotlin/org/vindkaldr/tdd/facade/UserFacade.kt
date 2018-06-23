package org.vindkaldr.tdd.facade

class UserFacade constructor(
    private val permissionChecker: PermissionChecker,
    private val userStorage: UserStorage
) {
    fun addUser(username: String, email: String) {
        require(username.isNotBlank())
        require(email.isNotBlank())

        if (!permissionChecker.isAllowedToAddUser()) {
            throw SecurityException()
        }
        userStorage.createUser(username, email)
    }
}
