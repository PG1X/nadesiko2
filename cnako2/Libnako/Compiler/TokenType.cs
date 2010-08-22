﻿
using System;
using System.Collections.Generic;
using System.Text;

namespace Libnako.Parser
{
    public enum TokenType
    {
        // Define Token
        T_UNKNOWN = 0,
        // Literal
        T_RESERVED = 1,
        T_COMMENT = 2,
        T_EOL = 3,
        T_WORD = 4,
        T_FUNCTION_NAME = 5,
        T_NUMBER = 6,
        T_INT = 7,
        T_STRING = 8,
        T_STRING_EX = 9,
        // Flow Controll
        T_IF = 10,
        T_WHILE = 11,
        T_SWITCH = 12,
        T_FOR = 13,
        T_FOREACH = 14,
        //
        T_THEN = 15,
        T_KOKOMADE = 16,
        //
        T_DEF_FUNCTION = 17,
        T_DEF_GROUP = 18,
        // Flags
        T_EQ = 19,
        T_EQ_EQ = 20,
        T_NOT_EQ = 21,
        T_GT = 22,
        T_GT_EQ = 23,
        T_LT = 24,
        T_LT_EQ = 25,
        T_NOT = 26,
        T_AND = 27,
        T_AND_AND = 28,
        T_OR = 29,
        T_OR_OR = 30,
        T_PLUS = 31,
        T_MINUS = 32,
        T_MUL = 33,
        T_DIV = 34,
        T_MOD = 35,
        T_POWER = 36,
        // 角カッコ
        T_BLACKETS_L = 37,
        T_BLACKETS_R = 38,
        // 丸括弧
        T_PARENTHESES_L = 39,
        T_PARENTHESES_R = 40,
        // 波括弧(中括弧)
        T_BRANCES_L = 41,
        T_BRANCES_R = 42,
        // DEBUG
        T_PRINT = 43,

        END_OF_TOKEN
    }
    public class TokenTypeDescriptor
    {
        // Token Description
        public static String[] TypeName = new String[] {
"T_UNKNOWN","T_RESERVED","T_COMMENT","T_EOL","T_WORD","T_FUNCTION_NAME","T_NUMBER","T_INT","T_STRING",
"T_STRING_EX","T_IF","T_WHILE","T_SWITCH","T_FOR","T_FOREACH","T_THEN","T_KOKOMADE","T_DEF_FUNCTION","T_DEF_GROUP",

"T_EQ","T_EQ_EQ","T_NOT_EQ","T_GT","T_GT_EQ","T_LT","T_LT_EQ","T_NOT","T_AND","T_AND_AND",
"T_OR","T_OR_OR","T_PLUS","T_MINUS","T_MUL","T_DIV","T_MOD","T_POWER","T_BLACKETS_L","T_BLACKETS_R",

"T_PARENTHESES_L","T_PARENTHESES_R","T_BRANCES_L","T_BRANCES_R","T_PRINT",
        };
        // Description Method
        public static String GetTypeName(TokenType t)
        {
            int no = (int)t;
            if (TypeName.Length > no) {
                return TypeName[no];
            }
            else
            {
                return "UNKNOWN";
            }
        }
    }
}