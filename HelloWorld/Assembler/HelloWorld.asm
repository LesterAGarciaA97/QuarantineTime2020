; Hello World from Assembler
.MODEL small
.DATA
; Variable containing the text
cadena DB 'Hello World from Assembler!$' ; $ means the end of the chain

.STACK
.CODE

Programa: ; Program start tag
; Initialize program 
MOV AX, @Data ; Saving start address data segment
MOV DS, AX

; Print string
MOV DX, OFFSET cadena ;Assigning DX the string variable
MOV AH, 09h           ;A string will be printed
INT 21h               ;Run the interruption, it will print

; Program completion
MOV AH, 4Ch ; End process
INT 21h ; Execute interrupt
END Programa