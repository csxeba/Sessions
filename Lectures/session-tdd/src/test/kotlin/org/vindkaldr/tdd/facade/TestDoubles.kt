package org.vindkaldr.tdd.facade

// test doubles: http://xunitpatterns.com/Test%20Double.html

// Dummy
class DummyPermissionChecker : PermissionChecker {
    override fun isAllowedToAddUser(): Boolean {
        return false
    }
}

// Stub
class RejectingPermissionChecker : PermissionChecker {
    override fun isAllowedToAddUser(): Boolean {
        return false
    }
}

// Stub
class AllowingPermissionChecker : PermissionChecker {
    override fun isAllowedToAddUser(): Boolean {
        return true
    }
}

// Dummy
class DummyUserStorage : UserStorage {
    override fun createUser(username: String, email: String) {}
}

// Spy
class UserStorageSpy : UserStorage {
    lateinit var capturedUsername: String
    lateinit var capturedEmail: String

    override fun createUser(username: String, email: String) {
        capturedUsername = username
        capturedEmail = email
    }
}

// Mock
class MockUserStorage : UserStorage {
    private lateinit var capturedUsername: String
    private lateinit var capturedEmail: String

    override fun createUser(username: String, email: String) {
        capturedUsername = username
        capturedEmail = email
    }

    fun verifyUserWasCreated(username: String, email: String): Boolean {
        return capturedUsername == username && capturedEmail == email
    }
}
