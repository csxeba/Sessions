package org.vindkaldr.tdd.primefactors

object PrimeFactors {
    fun generate(n: Int): List<Int> {
        val factors = mutableListOf<Int>()
        var number = n

        var divisor = 2
        while(number > 1) {
            while (number % divisor == 0) {
                factors.add(divisor)
                number /= divisor
            }
            divisor++
        }

        return factors
    }
}
