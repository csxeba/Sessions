package org.vindkaldr.tdd.facade

import com.natpryce.hamkrest.assertion.assert
import com.natpryce.hamkrest.equalTo
import com.natpryce.hamkrest.throws
import org.junit.Test

private const val USERNAME = "username"
private const val EMAIL = "email"

class UserFacadeTest {
    @Test
    fun `throws when username is blank`() {
        val userFacade = UserFacade(DummyPermissionChecker(), DummyUserStorage())

        assert.that({ userFacade.addUser("", "") }, throws<IllegalArgumentException>())
    }

    @Test
    fun `throws when email is blank`() {
        val userFacade = UserFacade(DummyPermissionChecker(), DummyUserStorage())

        assert.that({ userFacade.addUser(USERNAME, "") }, throws<IllegalArgumentException>())
    }

    @Test
    fun `throws when not allowed to add user`() {
        val userFacade = UserFacade(RejectingPermissionChecker(), DummyUserStorage())

        assert.that({ userFacade.addUser(USERNAME, EMAIL) }, throws<SecurityException>())
    }

    @Test
    fun `adds user (verification with a spy)`() {
        val userStorage = UserStorageSpy()
        val userFacade = UserFacade(AllowingPermissionChecker(), userStorage)

        userFacade.addUser(USERNAME, EMAIL)

        assert.that(userStorage.capturedUsername, equalTo(USERNAME))
        assert.that(userStorage.capturedEmail, equalTo(EMAIL))
    }

    @Test
    fun `adds user (verification with a mock)`() {
        val userStorage = MockUserStorage()
        val userFacade = UserFacade(AllowingPermissionChecker(), userStorage)

        userFacade.addUser(USERNAME, EMAIL)

        assert.that(userStorage.verifyUserWasCreated(USERNAME, EMAIL), equalTo(true))
    }
}
