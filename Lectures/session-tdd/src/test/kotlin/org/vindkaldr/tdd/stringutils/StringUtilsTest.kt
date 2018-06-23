package org.vindkaldr.tdd.stringutils

import com.natpryce.hamkrest.assertion.assert
import com.natpryce.hamkrest.equalTo
import com.natpryce.hamkrest.throws
import org.junit.Test

// kotlin: https://kotlinlang.org
// junit: https://junit.org/junit4
// hamkrest: https://github.com/npryce/hamkrest

class StringUtilsTest {
    @Test
    fun `throws for empty word`() {
        assert.that({ StringUtils.capitalizeWord("") }, throws<IllegalArgumentException>())
    }

    @Test
    fun `throws for multi word string`() {
        assert.that({ StringUtils.capitalizeWord("glass sword") }, throws<IllegalArgumentException>())
    }

    @Test
    fun `capitalizes single character word`() {
        assert.that(StringUtils.capitalizeWord("s"), equalTo("S"))
    }

    @Test
    fun `capitalizes word`() {
        assert.that(StringUtils.capitalizeWord("sword"), equalTo("Sword"))
    }
}
