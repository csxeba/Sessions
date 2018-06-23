package org.vindkaldr.tdd.stringutils

object StringUtils {
    fun capitalizeWord(word: String): String {
        require(word.isNotBlank())
        require(isNotMultiWord(word))
        return word[0].toUpperCase() + word.substring(1)
    }

    private fun isNotMultiWord(word: String): Boolean {
        return !word.contains(Regex("\\s"))
    }
}
