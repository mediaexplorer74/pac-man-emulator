
namespace JustinCredible.ZilogZ80
{
    // A list of all the "IX" opcodes and their metadata.
    // These are multi-byte opcodes, where the first byte is defined by OpcodeBytes.PREAMBLE_IX (0xDD).
    public partial class Opcodes
    {
        #region Add

            #region Add (Addresses)

                public static Opcode ADD_IX_BC = new Opcode(OpcodeBytes.ADD_IX_BC, instructionSet: InstructionSet.IX, size: 2, instruction: "ADD IX, BC", cycles: 15, pseudocode: "IX = IX + BC");
                public static Opcode ADD_IX_DE = new Opcode(OpcodeBytes.ADD_IX_DE, instructionSet: InstructionSet.IX, size: 2, instruction: "ADD IX, DE", cycles: 15, pseudocode: "IX = IX + DE");
                public static Opcode ADD_IX_IX = new Opcode(OpcodeBytes.ADD_IX_IX, instructionSet: InstructionSet.IX, size: 2, instruction: "ADD IX, IX", cycles: 15, pseudocode: "IX = IX + IX");
                public static Opcode ADD_IX_SP = new Opcode(OpcodeBytes.ADD_IX_SP, instructionSet: InstructionSet.IX, size: 2, instruction: "ADD IX, SP", cycles: 15, pseudocode: "IX = IX + SP");

            #endregion

            #region Add (Arithmetic)

                public static Opcode ADD_A_IX = new Opcode(OpcodeBytes.ADD_A_IX, instructionSet: InstructionSet.IX, size: 3, instruction: "ADD A, (IX+n)", cycles: 19, pseudocode: "A = A + (IX+n)");

                public static Opcode ADD_A_IXH = new Opcode(OpcodeBytes.ADD_A_IXH, instructionSet: InstructionSet.IX, size: 2, instruction: "ADD A, IXH", cycles: 8, pseudocode: "A = A + IX.hi");
                public static Opcode ADD_A_IXL = new Opcode(OpcodeBytes.ADD_A_IXL, instructionSet: InstructionSet.IX, size: 2, instruction: "ADD A, IXL", cycles: 8, pseudocode: "A = A + IX.lo");

                public static Opcode ADC_A_IX = new Opcode(OpcodeBytes.ADC_A_IX, instructionSet: InstructionSet.IX, size: 3, instruction: "ADC A, (IX+n)", cycles: 19, pseudocode: "A = A + (IX+n) + CY");

                public static Opcode ADC_A_IXH = new Opcode(OpcodeBytes.ADC_A_IXH, instructionSet: InstructionSet.IX, size: 2, instruction: "ADC A, IXH", cycles: 8, pseudocode: "A = A + IX.hi + CY");
                public static Opcode ADC_A_IXL = new Opcode(OpcodeBytes.ADC_A_IXL, instructionSet: InstructionSet.IX, size: 2, instruction: "ADC A, IXL", cycles: 8, pseudocode: "A = A + IX.lo + CY");

            #endregion

        #endregion

        #region Subtract

            public static Opcode SUB_IX = new Opcode(OpcodeBytes.SUB_IX, instructionSet: InstructionSet.IX, size: 3, instruction: "SUB (IX+n)", cycles: 19, pseudocode: "A = A - (IX+n)");

            public static Opcode SUB_IXH = new Opcode(OpcodeBytes.SUB_IXH, instructionSet: InstructionSet.IX, size: 2, instruction: "SUB IXH", cycles: 8, pseudocode: "A = A - IX.hi");
            public static Opcode SUB_IXL = new Opcode(OpcodeBytes.SUB_IXL, instructionSet: InstructionSet.IX, size: 2, instruction: "SUB IXL", cycles: 8, pseudocode: "A = A - IX.lo");

            public static Opcode SBC_A_IX = new Opcode(OpcodeBytes.SBC_A_IX, instructionSet: InstructionSet.IX, size: 3, instruction: "SBC A, (IX+n)", cycles: 19, pseudocode: "A = A - (IX+n) - CY");

            public static Opcode SBC_A_IXH = new Opcode(OpcodeBytes.SBC_A_IXH, instructionSet: InstructionSet.IX, size: 2, instruction: "SBC A, IXH", cycles: 8, pseudocode: "A = A - IX.hi - CY");
            public static Opcode SBC_A_IXL = new Opcode(OpcodeBytes.SBC_A_IXL, instructionSet: InstructionSet.IX, size: 2, instruction: "SBC A, IXL", cycles: 8, pseudocode: "A = A - IX.lo - CY");

        #endregion

        #region Compare

            public static Opcode CP_IX = new Opcode(OpcodeBytes.CP_IX, instructionSet: InstructionSet.IX, size: 3, instruction: "CP (IX+n)", cycles: 19, pseudocode: "CP (IX+n)");

            public static Opcode CP_IXH = new Opcode(OpcodeBytes.CP_IXH, instructionSet: InstructionSet.IX, size: 2, instruction: "CP IXH", cycles: 8, pseudocode: "CP IX.hi");
            public static Opcode CP_IXL = new Opcode(OpcodeBytes.CP_IXL, instructionSet: InstructionSet.IX, size: 2, instruction: "CP IXL", cycles: 8, pseudocode: "CP IX.lo");

        #endregion

        #region Bitwise Operations

            #region Bitwise AND

                public static Opcode AND_IX = new Opcode(OpcodeBytes.AND_IX, instructionSet: InstructionSet.IX, size: 3, instruction: "AND (IX+x)", cycles: 19, pseudocode: "A = A & (IX+x)");

                public static Opcode AND_IXH = new Opcode(OpcodeBytes.AND_IXH, instructionSet: InstructionSet.IX, size: 2, instruction: "AND IXH", cycles: 8, pseudocode: "A = A & IX.hi");
                public static Opcode AND_IXL = new Opcode(OpcodeBytes.AND_IXL, instructionSet: InstructionSet.IX, size: 2, instruction: "AND IXL", cycles: 8, pseudocode: "A = A & IX.lo");

            #endregion

            #region Bitwise OR

                public static Opcode OR_IX = new Opcode(OpcodeBytes.OR_IX, instructionSet: InstructionSet.IX, size: 3, instruction: "OR (IX+n)", cycles: 19, pseudocode: "A = A & (IX+x)");

                public static Opcode OR_IXH = new Opcode(OpcodeBytes.OR_IXH, instructionSet: InstructionSet.IX, size: 2, instruction: "OR IXH", cycles: 8, pseudocode: "A = A | IX.hi");
                public static Opcode OR_IXL = new Opcode(OpcodeBytes.OR_IXL, instructionSet: InstructionSet.IX, size: 2, instruction: "OR IXL", cycles: 8, pseudocode: "A = A | IX.lo");

            #endregion

            #region Bitwise XOR

                public static Opcode XOR_IX = new Opcode(OpcodeBytes.XOR_IX, instructionSet: InstructionSet.IX, size: 3, instruction: "XOR (IX+n)", cycles: 19, pseudocode: "A = A & (IX+x)");

                public static Opcode XOR_IXH = new Opcode(OpcodeBytes.XOR_IXH, instructionSet: InstructionSet.IX, size: 2, instruction: "XOR IXH", cycles: 8, pseudocode: "A = A ^ IX.hi");
                public static Opcode XOR_IXL = new Opcode(OpcodeBytes.XOR_IXL, instructionSet: InstructionSet.IX, size: 2, instruction: "XOR IXL", cycles: 8, pseudocode: "A = A ^ IX.lo");

            #endregion

        #endregion

        #region Load

            public static Opcode LD_MIX_B = new Opcode(OpcodeBytes.LD_MIX_B, instructionSet: InstructionSet.IX, size: 3, instruction: "LD (IX+n), B", cycles: 19, pseudocode: "(IX+n) = B");
            public static Opcode LD_MIX_C = new Opcode(OpcodeBytes.LD_MIX_C, instructionSet: InstructionSet.IX, size: 3, instruction: "LD (IX+n), C", cycles: 19, pseudocode: "(IX+n) = C");
            public static Opcode LD_MIX_D = new Opcode(OpcodeBytes.LD_MIX_D, instructionSet: InstructionSet.IX, size: 3, instruction: "LD (IX+n), D", cycles: 19, pseudocode: "(IX+n) = D");
            public static Opcode LD_MIX_E = new Opcode(OpcodeBytes.LD_MIX_E, instructionSet: InstructionSet.IX, size: 3, instruction: "LD (IX+n), E", cycles: 19, pseudocode: "(IX+n) = E");
            public static Opcode LD_MIX_H = new Opcode(OpcodeBytes.LD_MIX_H, instructionSet: InstructionSet.IX, size: 3, instruction: "LD (IX+n), H", cycles: 19, pseudocode: "(IX+n) = H");
            public static Opcode LD_MIX_L = new Opcode(OpcodeBytes.LD_MIX_L, instructionSet: InstructionSet.IX, size: 3, instruction: "LD (IX+n), L", cycles: 19, pseudocode: "(IX+n) = L");
            public static Opcode LD_MIX_A = new Opcode(OpcodeBytes.LD_MIX_A, instructionSet: InstructionSet.IX, size: 3, instruction: "LD (IX+n), A", cycles: 19, pseudocode: "(IX+n) = A");

        #endregion
    }
}