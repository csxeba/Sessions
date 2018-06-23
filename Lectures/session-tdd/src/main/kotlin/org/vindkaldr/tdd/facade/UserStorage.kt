package org.vindkaldr.tdd.facade

interface UserStorage {
    fun createUser(username: String, email: String)
}
