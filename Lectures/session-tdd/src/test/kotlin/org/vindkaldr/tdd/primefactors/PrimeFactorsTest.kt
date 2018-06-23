package org.vindkaldr.tdd.primefactors

import com.natpryce.hamkrest.assertion.assert
import com.natpryce.hamkrest.equalTo
import org.junit.Test

// prime factors kata: http://www.butunclebob.com/ArticleS.UncleBob.ThePrimeFactorsKata

class PrimeFactorsTest {
    @Test
    fun `generates factors of one`() {
        assertFactors(1, emptyList())
    }

    @Test
    fun `generates factors of two`() {
        assertFactors(2, listOf(2))
    }

    @Test
    fun `generates factors of three`() {
        assertFactors(3, listOf(3))
    }

    @Test
    fun `generates factors of four`() {
        assertFactors(4, listOf(2, 2))
    }

    @Test
    fun `generates factors of five`() {
        assertFactors(5, listOf(5))
    }

    @Test
    fun `generates factors of six`() {
        assertFactors(6, listOf(2, 3))
    }

    @Test
    fun `generates factors of seven`() {
        assertFactors(7, listOf(7))
    }

    @Test
    fun `generates factors of eight`() {
        assertFactors(8, listOf(2, 2, 2))
    }

    @Test
    fun `generates factors of nine`() {
        assertFactors(9, listOf(3, 3))
    }

    @Test
    fun `generates factors of six hundred sixty six`() {
        assertFactors(666, listOf(2, 3, 3, 37))
    }

    private fun assertFactors(number: Int, expectedFactors: List<Int>) {
        assert.that(PrimeFactors.generate(number), equalTo(expectedFactors))
    }
}
