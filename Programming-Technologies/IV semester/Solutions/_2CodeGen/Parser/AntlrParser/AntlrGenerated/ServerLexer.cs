//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.9.2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from /Users/artyomfadeyev/GitHub/ITMO-PROBLEMS/Programming-Technologies/IV semester/Solutions/_2CodeGen/Parser/AntlrParser/Server.g4 by ANTLR 4.9.2

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.9.2")]
[System.CLSCompliant(false)]
public partial class ServerLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, PACKAGE=6, IMPORT=7, MODEL_TYPE=8, 
		ACCESS_MODIFIER=9, NON_ACCESS_MODIFIER=10, INHERITANCE_TYPE=11, WS=12, 
		NAME=13, TYPE=14, PATH=15, KEY_VALUE=16, ANNOTATION_HEADER=17, ANNOTATION_ARGS=18, 
		ANY=19;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "T__2", "T__3", "T__4", "PACKAGE", "IMPORT", "MODEL_TYPE", 
		"ACCESS_MODIFIER", "NON_ACCESS_MODIFIER", "INHERITANCE_TYPE", "WS", "LETTER", 
		"WORD", "DIGIT", "NUMBER", "NAME", "TYPE", "PATH", "KEY_VALUE", "VALUE", 
		"STRING", "ANNOTATION_HEADER", "ANNOTATION_ARG", "ANNOTATION_ARGS", "ANY"
	};


	public ServerLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public ServerLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, "','", "'{'", "'}'", "'('", "')'", "'package'", "'import'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, "PACKAGE", "IMPORT", "MODEL_TYPE", 
		"ACCESS_MODIFIER", "NON_ACCESS_MODIFIER", "INHERITANCE_TYPE", "WS", "NAME", 
		"TYPE", "PATH", "KEY_VALUE", "ANNOTATION_HEADER", "ANNOTATION_ARGS", "ANY"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "Server.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static ServerLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x2', '\x15', '\x120', '\b', '\x1', '\x4', '\x2', '\t', '\x2', 
		'\x4', '\x3', '\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', 
		'\x5', '\x4', '\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', 
		'\t', '\b', '\x4', '\t', '\t', '\t', '\x4', '\n', '\t', '\n', '\x4', '\v', 
		'\t', '\v', '\x4', '\f', '\t', '\f', '\x4', '\r', '\t', '\r', '\x4', '\xE', 
		'\t', '\xE', '\x4', '\xF', '\t', '\xF', '\x4', '\x10', '\t', '\x10', '\x4', 
		'\x11', '\t', '\x11', '\x4', '\x12', '\t', '\x12', '\x4', '\x13', '\t', 
		'\x13', '\x4', '\x14', '\t', '\x14', '\x4', '\x15', '\t', '\x15', '\x4', 
		'\x16', '\t', '\x16', '\x4', '\x17', '\t', '\x17', '\x4', '\x18', '\t', 
		'\x18', '\x4', '\x19', '\t', '\x19', '\x4', '\x1A', '\t', '\x1A', '\x4', 
		'\x1B', '\t', '\x1B', '\x3', '\x2', '\x3', '\x2', '\x3', '\x3', '\x3', 
		'\x3', '\x3', '\x4', '\x3', '\x4', '\x3', '\x5', '\x3', '\x5', '\x3', 
		'\x6', '\x3', '\x6', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', 
		'\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\b', '\x3', 
		'\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', 
		'\x3', '\t', '\x3', '\t', '\x3', '\t', '\x3', '\t', '\x3', '\t', '\x3', 
		'\t', '\x3', '\t', '\x3', '\t', '\x3', '\t', '\x3', '\t', '\x3', '\t', 
		'\x3', '\t', '\x3', '\t', '\x3', '\t', '\x5', '\t', '_', '\n', '\t', '\x3', 
		'\n', '\x3', '\n', '\x3', '\n', '\x3', '\n', '\x3', '\n', '\x3', '\n', 
		'\x3', '\n', '\x3', '\n', '\x3', '\n', '\x3', '\n', '\x3', '\n', '\x3', 
		'\n', '\x3', '\n', '\x3', '\n', '\x3', '\n', '\x3', '\n', '\x3', '\n', 
		'\x3', '\n', '\x3', '\n', '\x3', '\n', '\x3', '\n', '\x3', '\n', '\x5', 
		'\n', 'w', '\n', '\n', '\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', '\v', 
		'\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', 
		'\v', '\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', '\v', 
		'\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', '\v', '\x5', '\v', '\x8C', 
		'\n', '\v', '\x3', '\f', '\x3', '\f', '\x3', '\f', '\x3', '\f', '\x3', 
		'\f', '\x3', '\f', '\x3', '\f', '\x3', '\f', '\x3', '\f', '\x3', '\f', 
		'\x3', '\f', '\x3', '\f', '\x3', '\f', '\x3', '\f', '\x3', '\f', '\x3', 
		'\f', '\x3', '\f', '\x5', '\f', '\x9F', '\n', '\f', '\x3', '\r', '\x3', 
		'\r', '\x3', '\r', '\x3', '\r', '\x3', '\xE', '\x3', '\xE', '\x3', '\xF', 
		'\x6', '\xF', '\xA8', '\n', '\xF', '\r', '\xF', '\xE', '\xF', '\xA9', 
		'\x3', '\x10', '\x3', '\x10', '\x3', '\x11', '\x6', '\x11', '\xAF', '\n', 
		'\x11', '\r', '\x11', '\xE', '\x11', '\xB0', '\x3', '\x11', '\x3', '\x11', 
		'\x3', '\x11', '\x3', '\x11', '\x6', '\x11', '\xB7', '\n', '\x11', '\r', 
		'\x11', '\xE', '\x11', '\xB8', '\x5', '\x11', '\xBB', '\n', '\x11', '\x3', 
		'\x12', '\x3', '\x12', '\x5', '\x12', '\xBF', '\n', '\x12', '\x3', '\x12', 
		'\x3', '\x12', '\x3', '\x12', '\a', '\x12', '\xC4', '\n', '\x12', '\f', 
		'\x12', '\xE', '\x12', '\xC7', '\v', '\x12', '\x3', '\x13', '\x3', '\x13', 
		'\x3', '\x13', '\x3', '\x13', '\x6', '\x13', '\xCD', '\n', '\x13', '\r', 
		'\x13', '\xE', '\x13', '\xCE', '\x3', '\x14', '\x3', '\x14', '\x5', '\x14', 
		'\xD3', '\n', '\x14', '\a', '\x14', '\xD5', '\n', '\x14', '\f', '\x14', 
		'\xE', '\x14', '\xD8', '\v', '\x14', '\x3', '\x14', '\x3', '\x14', '\x3', 
		'\x14', '\x5', '\x14', '\xDD', '\n', '\x14', '\x6', '\x14', '\xDF', '\n', 
		'\x14', '\r', '\x14', '\xE', '\x14', '\xE0', '\x3', '\x14', '\x5', '\x14', 
		'\xE4', '\n', '\x14', '\x5', '\x14', '\xE6', '\n', '\x14', '\x3', '\x15', 
		'\x3', '\x15', '\x5', '\x15', '\xEA', '\n', '\x15', '\x3', '\x15', '\x3', 
		'\x15', '\x5', '\x15', '\xEE', '\n', '\x15', '\x3', '\x15', '\x3', '\x15', 
		'\x3', '\x16', '\x3', '\x16', '\x3', '\x16', '\x5', '\x16', '\xF5', '\n', 
		'\x16', '\x3', '\x16', '\x5', '\x16', '\xF8', '\n', '\x16', '\x6', '\x16', 
		'\xFA', '\n', '\x16', '\r', '\x16', '\xE', '\x16', '\xFB', '\x3', '\x17', 
		'\x3', '\x17', '\x6', '\x17', '\x100', '\n', '\x17', '\r', '\x17', '\xE', 
		'\x17', '\x101', '\x3', '\x17', '\x3', '\x17', '\x3', '\x18', '\x3', '\x18', 
		'\x3', '\x18', '\x3', '\x19', '\x3', '\x19', '\x5', '\x19', '\x10B', '\n', 
		'\x19', '\x3', '\x1A', '\x3', '\x1A', '\x3', '\x1A', '\x5', '\x1A', '\x110', 
		'\n', '\x1A', '\x3', '\x1A', '\x5', '\x1A', '\x113', '\n', '\x1A', '\a', 
		'\x1A', '\x115', '\n', '\x1A', '\f', '\x1A', '\xE', '\x1A', '\x118', '\v', 
		'\x1A', '\x3', '\x1A', '\x3', '\x1A', '\x3', '\x1B', '\x6', '\x1B', '\x11D', 
		'\n', '\x1B', '\r', '\x1B', '\xE', '\x1B', '\x11E', '\x3', '\x11E', '\x2', 
		'\x1C', '\x3', '\x3', '\x5', '\x4', '\a', '\x5', '\t', '\x6', '\v', '\a', 
		'\r', '\b', '\xF', '\t', '\x11', '\n', '\x13', '\v', '\x15', '\f', '\x17', 
		'\r', '\x19', '\xE', '\x1B', '\x2', '\x1D', '\x2', '\x1F', '\x2', '!', 
		'\x2', '#', '\xF', '%', '\x10', '\'', '\x11', ')', '\x12', '+', '\x2', 
		'-', '\x2', '/', '\x13', '\x31', '\x2', '\x33', '\x14', '\x35', '\x15', 
		'\x3', '\x2', '\a', '\x5', '\x2', '\v', '\f', '\"', '\"', '=', '=', '\x4', 
		'\x2', '\x43', '\\', '\x63', '|', '\x3', '\x2', '\x32', ';', '\x5', '\x2', 
		'\x30', '\x30', '>', '>', '@', '@', '\x4', '\x2', '\f', '\f', '=', '=', 
		'\x2', '\x13C', '\x2', '\x3', '\x3', '\x2', '\x2', '\x2', '\x2', '\x5', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\a', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\t', '\x3', '\x2', '\x2', '\x2', '\x2', '\v', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\r', '\x3', '\x2', '\x2', '\x2', '\x2', '\xF', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x11', '\x3', '\x2', '\x2', '\x2', '\x2', '\x13', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x15', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x17', '\x3', '\x2', '\x2', '\x2', '\x2', '\x19', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '#', '\x3', '\x2', '\x2', '\x2', '\x2', '%', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\'', '\x3', '\x2', '\x2', '\x2', '\x2', ')', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '/', '\x3', '\x2', '\x2', '\x2', '\x2', '\x33', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\x35', '\x3', '\x2', '\x2', '\x2', 
		'\x3', '\x37', '\x3', '\x2', '\x2', '\x2', '\x5', '\x39', '\x3', '\x2', 
		'\x2', '\x2', '\a', ';', '\x3', '\x2', '\x2', '\x2', '\t', '=', '\x3', 
		'\x2', '\x2', '\x2', '\v', '?', '\x3', '\x2', '\x2', '\x2', '\r', '\x41', 
		'\x3', '\x2', '\x2', '\x2', '\xF', 'I', '\x3', '\x2', '\x2', '\x2', '\x11', 
		'^', '\x3', '\x2', '\x2', '\x2', '\x13', 'v', '\x3', '\x2', '\x2', '\x2', 
		'\x15', '\x8B', '\x3', '\x2', '\x2', '\x2', '\x17', '\x9E', '\x3', '\x2', 
		'\x2', '\x2', '\x19', '\xA0', '\x3', '\x2', '\x2', '\x2', '\x1B', '\xA4', 
		'\x3', '\x2', '\x2', '\x2', '\x1D', '\xA7', '\x3', '\x2', '\x2', '\x2', 
		'\x1F', '\xAB', '\x3', '\x2', '\x2', '\x2', '!', '\xAE', '\x3', '\x2', 
		'\x2', '\x2', '#', '\xBE', '\x3', '\x2', '\x2', '\x2', '%', '\xCC', '\x3', 
		'\x2', '\x2', '\x2', '\'', '\xE5', '\x3', '\x2', '\x2', '\x2', ')', '\xE7', 
		'\x3', '\x2', '\x2', '\x2', '+', '\xF9', '\x3', '\x2', '\x2', '\x2', '-', 
		'\xFD', '\x3', '\x2', '\x2', '\x2', '/', '\x105', '\x3', '\x2', '\x2', 
		'\x2', '\x31', '\x10A', '\x3', '\x2', '\x2', '\x2', '\x33', '\x10C', '\x3', 
		'\x2', '\x2', '\x2', '\x35', '\x11C', '\x3', '\x2', '\x2', '\x2', '\x37', 
		'\x38', '\a', '.', '\x2', '\x2', '\x38', '\x4', '\x3', '\x2', '\x2', '\x2', 
		'\x39', ':', '\a', '}', '\x2', '\x2', ':', '\x6', '\x3', '\x2', '\x2', 
		'\x2', ';', '<', '\a', '\x7F', '\x2', '\x2', '<', '\b', '\x3', '\x2', 
		'\x2', '\x2', '=', '>', '\a', '*', '\x2', '\x2', '>', '\n', '\x3', '\x2', 
		'\x2', '\x2', '?', '@', '\a', '+', '\x2', '\x2', '@', '\f', '\x3', '\x2', 
		'\x2', '\x2', '\x41', '\x42', '\a', 'r', '\x2', '\x2', '\x42', '\x43', 
		'\a', '\x63', '\x2', '\x2', '\x43', '\x44', '\a', '\x65', '\x2', '\x2', 
		'\x44', '\x45', '\a', 'm', '\x2', '\x2', '\x45', '\x46', '\a', '\x63', 
		'\x2', '\x2', '\x46', 'G', '\a', 'i', '\x2', '\x2', 'G', 'H', '\a', 'g', 
		'\x2', '\x2', 'H', '\xE', '\x3', '\x2', '\x2', '\x2', 'I', 'J', '\a', 
		'k', '\x2', '\x2', 'J', 'K', '\a', 'o', '\x2', '\x2', 'K', 'L', '\a', 
		'r', '\x2', '\x2', 'L', 'M', '\a', 'q', '\x2', '\x2', 'M', 'N', '\a', 
		't', '\x2', '\x2', 'N', 'O', '\a', 'v', '\x2', '\x2', 'O', '\x10', '\x3', 
		'\x2', '\x2', '\x2', 'P', 'Q', '\a', '\x65', '\x2', '\x2', 'Q', 'R', '\a', 
		'n', '\x2', '\x2', 'R', 'S', '\a', '\x63', '\x2', '\x2', 'S', 'T', '\a', 
		'u', '\x2', '\x2', 'T', '_', '\a', 'u', '\x2', '\x2', 'U', 'V', '\a', 
		'k', '\x2', '\x2', 'V', 'W', '\a', 'p', '\x2', '\x2', 'W', 'X', '\a', 
		'v', '\x2', '\x2', 'X', 'Y', '\a', 'g', '\x2', '\x2', 'Y', 'Z', '\a', 
		't', '\x2', '\x2', 'Z', '[', '\a', 'h', '\x2', '\x2', '[', '\\', '\a', 
		'\x63', '\x2', '\x2', '\\', ']', '\a', '\x65', '\x2', '\x2', ']', '_', 
		'\a', 'g', '\x2', '\x2', '^', 'P', '\x3', '\x2', '\x2', '\x2', '^', 'U', 
		'\x3', '\x2', '\x2', '\x2', '_', '\x12', '\x3', '\x2', '\x2', '\x2', '`', 
		'\x61', '\a', 'r', '\x2', '\x2', '\x61', '\x62', '\a', 'w', '\x2', '\x2', 
		'\x62', '\x63', '\a', '\x64', '\x2', '\x2', '\x63', '\x64', '\a', 'n', 
		'\x2', '\x2', '\x64', '\x65', '\a', 'k', '\x2', '\x2', '\x65', 'w', '\a', 
		'\x65', '\x2', '\x2', '\x66', 'g', '\a', 'r', '\x2', '\x2', 'g', 'h', 
		'\a', 't', '\x2', '\x2', 'h', 'i', '\a', 'k', '\x2', '\x2', 'i', 'j', 
		'\a', 'x', '\x2', '\x2', 'j', 'k', '\a', '\x63', '\x2', '\x2', 'k', 'l', 
		'\a', 'v', '\x2', '\x2', 'l', 'w', '\a', 'g', '\x2', '\x2', 'm', 'n', 
		'\a', 'r', '\x2', '\x2', 'n', 'o', '\a', 't', '\x2', '\x2', 'o', 'p', 
		'\a', 'q', '\x2', '\x2', 'p', 'q', '\a', 'v', '\x2', '\x2', 'q', 'r', 
		'\a', 'g', '\x2', '\x2', 'r', 's', '\a', '\x65', '\x2', '\x2', 's', 't', 
		'\a', 'v', '\x2', '\x2', 't', 'u', '\a', 'g', '\x2', '\x2', 'u', 'w', 
		'\a', '\x66', '\x2', '\x2', 'v', '`', '\x3', '\x2', '\x2', '\x2', 'v', 
		'\x66', '\x3', '\x2', '\x2', '\x2', 'v', 'm', '\x3', '\x2', '\x2', '\x2', 
		'w', '\x14', '\x3', '\x2', '\x2', '\x2', 'x', 'y', '\a', 'u', '\x2', '\x2', 
		'y', 'z', '\a', 'v', '\x2', '\x2', 'z', '{', '\a', '\x63', '\x2', '\x2', 
		'{', '|', '\a', 'v', '\x2', '\x2', '|', '}', '\a', 'k', '\x2', '\x2', 
		'}', '\x8C', '\a', '\x65', '\x2', '\x2', '~', '\x7F', '\a', '\x63', '\x2', 
		'\x2', '\x7F', '\x80', '\a', '\x64', '\x2', '\x2', '\x80', '\x81', '\a', 
		'u', '\x2', '\x2', '\x81', '\x82', '\a', 'v', '\x2', '\x2', '\x82', '\x83', 
		'\a', 't', '\x2', '\x2', '\x83', '\x84', '\a', '\x63', '\x2', '\x2', '\x84', 
		'\x85', '\a', '\x65', '\x2', '\x2', '\x85', '\x8C', '\a', 'v', '\x2', 
		'\x2', '\x86', '\x87', '\a', 'h', '\x2', '\x2', '\x87', '\x88', '\a', 
		'k', '\x2', '\x2', '\x88', '\x89', '\a', 'p', '\x2', '\x2', '\x89', '\x8A', 
		'\a', '\x63', '\x2', '\x2', '\x8A', '\x8C', '\a', 'n', '\x2', '\x2', '\x8B', 
		'x', '\x3', '\x2', '\x2', '\x2', '\x8B', '~', '\x3', '\x2', '\x2', '\x2', 
		'\x8B', '\x86', '\x3', '\x2', '\x2', '\x2', '\x8C', '\x16', '\x3', '\x2', 
		'\x2', '\x2', '\x8D', '\x8E', '\a', 'g', '\x2', '\x2', '\x8E', '\x8F', 
		'\a', 'z', '\x2', '\x2', '\x8F', '\x90', '\a', 'v', '\x2', '\x2', '\x90', 
		'\x91', '\a', 'g', '\x2', '\x2', '\x91', '\x92', '\a', 'p', '\x2', '\x2', 
		'\x92', '\x93', '\a', '\x66', '\x2', '\x2', '\x93', '\x9F', '\a', 'u', 
		'\x2', '\x2', '\x94', '\x95', '\a', 'k', '\x2', '\x2', '\x95', '\x96', 
		'\a', 'o', '\x2', '\x2', '\x96', '\x97', '\a', 'r', '\x2', '\x2', '\x97', 
		'\x98', '\a', 'n', '\x2', '\x2', '\x98', '\x99', '\a', 'g', '\x2', '\x2', 
		'\x99', '\x9A', '\a', 'o', '\x2', '\x2', '\x9A', '\x9B', '\a', 'g', '\x2', 
		'\x2', '\x9B', '\x9C', '\a', 'p', '\x2', '\x2', '\x9C', '\x9D', '\a', 
		'v', '\x2', '\x2', '\x9D', '\x9F', '\a', 'u', '\x2', '\x2', '\x9E', '\x8D', 
		'\x3', '\x2', '\x2', '\x2', '\x9E', '\x94', '\x3', '\x2', '\x2', '\x2', 
		'\x9F', '\x18', '\x3', '\x2', '\x2', '\x2', '\xA0', '\xA1', '\t', '\x2', 
		'\x2', '\x2', '\xA1', '\xA2', '\x3', '\x2', '\x2', '\x2', '\xA2', '\xA3', 
		'\b', '\r', '\x2', '\x2', '\xA3', '\x1A', '\x3', '\x2', '\x2', '\x2', 
		'\xA4', '\xA5', '\t', '\x3', '\x2', '\x2', '\xA5', '\x1C', '\x3', '\x2', 
		'\x2', '\x2', '\xA6', '\xA8', '\x5', '\x1B', '\xE', '\x2', '\xA7', '\xA6', 
		'\x3', '\x2', '\x2', '\x2', '\xA8', '\xA9', '\x3', '\x2', '\x2', '\x2', 
		'\xA9', '\xA7', '\x3', '\x2', '\x2', '\x2', '\xA9', '\xAA', '\x3', '\x2', 
		'\x2', '\x2', '\xAA', '\x1E', '\x3', '\x2', '\x2', '\x2', '\xAB', '\xAC', 
		'\t', '\x4', '\x2', '\x2', '\xAC', ' ', '\x3', '\x2', '\x2', '\x2', '\xAD', 
		'\xAF', '\x5', '\x1F', '\x10', '\x2', '\xAE', '\xAD', '\x3', '\x2', '\x2', 
		'\x2', '\xAF', '\xB0', '\x3', '\x2', '\x2', '\x2', '\xB0', '\xAE', '\x3', 
		'\x2', '\x2', '\x2', '\xB0', '\xB1', '\x3', '\x2', '\x2', '\x2', '\xB1', 
		'\xBA', '\x3', '\x2', '\x2', '\x2', '\xB2', '\xB3', '\a', '\x30', '\x2', 
		'\x2', '\xB3', '\xB4', '\a', '.', '\x2', '\x2', '\xB4', '\xB6', '\x3', 
		'\x2', '\x2', '\x2', '\xB5', '\xB7', '\x5', '\x1F', '\x10', '\x2', '\xB6', 
		'\xB5', '\x3', '\x2', '\x2', '\x2', '\xB7', '\xB8', '\x3', '\x2', '\x2', 
		'\x2', '\xB8', '\xB6', '\x3', '\x2', '\x2', '\x2', '\xB8', '\xB9', '\x3', 
		'\x2', '\x2', '\x2', '\xB9', '\xBB', '\x3', '\x2', '\x2', '\x2', '\xBA', 
		'\xB2', '\x3', '\x2', '\x2', '\x2', '\xBA', '\xBB', '\x3', '\x2', '\x2', 
		'\x2', '\xBB', '\"', '\x3', '\x2', '\x2', '\x2', '\xBC', '\xBF', '\x5', 
		'\x1B', '\xE', '\x2', '\xBD', '\xBF', '\a', '\x61', '\x2', '\x2', '\xBE', 
		'\xBC', '\x3', '\x2', '\x2', '\x2', '\xBE', '\xBD', '\x3', '\x2', '\x2', 
		'\x2', '\xBF', '\xC5', '\x3', '\x2', '\x2', '\x2', '\xC0', '\xC4', '\x5', 
		'\x1B', '\xE', '\x2', '\xC1', '\xC4', '\x5', '\x1F', '\x10', '\x2', '\xC2', 
		'\xC4', '\a', '\x61', '\x2', '\x2', '\xC3', '\xC0', '\x3', '\x2', '\x2', 
		'\x2', '\xC3', '\xC1', '\x3', '\x2', '\x2', '\x2', '\xC3', '\xC2', '\x3', 
		'\x2', '\x2', '\x2', '\xC4', '\xC7', '\x3', '\x2', '\x2', '\x2', '\xC5', 
		'\xC3', '\x3', '\x2', '\x2', '\x2', '\xC5', '\xC6', '\x3', '\x2', '\x2', 
		'\x2', '\xC6', '$', '\x3', '\x2', '\x2', '\x2', '\xC7', '\xC5', '\x3', 
		'\x2', '\x2', '\x2', '\xC8', '\xCD', '\x5', '\x1B', '\xE', '\x2', '\xC9', 
		'\xCD', '\t', '\x5', '\x2', '\x2', '\xCA', '\xCD', '\x5', '\x1F', '\x10', 
		'\x2', '\xCB', '\xCD', '\a', '\x61', '\x2', '\x2', '\xCC', '\xC8', '\x3', 
		'\x2', '\x2', '\x2', '\xCC', '\xC9', '\x3', '\x2', '\x2', '\x2', '\xCC', 
		'\xCA', '\x3', '\x2', '\x2', '\x2', '\xCC', '\xCB', '\x3', '\x2', '\x2', 
		'\x2', '\xCD', '\xCE', '\x3', '\x2', '\x2', '\x2', '\xCE', '\xCC', '\x3', 
		'\x2', '\x2', '\x2', '\xCE', '\xCF', '\x3', '\x2', '\x2', '\x2', '\xCF', 
		'&', '\x3', '\x2', '\x2', '\x2', '\xD0', '\xD2', '\x5', '\x1D', '\xF', 
		'\x2', '\xD1', '\xD3', '\a', '\x30', '\x2', '\x2', '\xD2', '\xD1', '\x3', 
		'\x2', '\x2', '\x2', '\xD2', '\xD3', '\x3', '\x2', '\x2', '\x2', '\xD3', 
		'\xD5', '\x3', '\x2', '\x2', '\x2', '\xD4', '\xD0', '\x3', '\x2', '\x2', 
		'\x2', '\xD5', '\xD8', '\x3', '\x2', '\x2', '\x2', '\xD6', '\xD4', '\x3', 
		'\x2', '\x2', '\x2', '\xD6', '\xD7', '\x3', '\x2', '\x2', '\x2', '\xD7', 
		'\xD9', '\x3', '\x2', '\x2', '\x2', '\xD8', '\xD6', '\x3', '\x2', '\x2', 
		'\x2', '\xD9', '\xE6', '\a', ',', '\x2', '\x2', '\xDA', '\xDC', '\x5', 
		'\x1D', '\xF', '\x2', '\xDB', '\xDD', '\a', '\x30', '\x2', '\x2', '\xDC', 
		'\xDB', '\x3', '\x2', '\x2', '\x2', '\xDC', '\xDD', '\x3', '\x2', '\x2', 
		'\x2', '\xDD', '\xDF', '\x3', '\x2', '\x2', '\x2', '\xDE', '\xDA', '\x3', 
		'\x2', '\x2', '\x2', '\xDF', '\xE0', '\x3', '\x2', '\x2', '\x2', '\xE0', 
		'\xDE', '\x3', '\x2', '\x2', '\x2', '\xE0', '\xE1', '\x3', '\x2', '\x2', 
		'\x2', '\xE1', '\xE3', '\x3', '\x2', '\x2', '\x2', '\xE2', '\xE4', '\a', 
		',', '\x2', '\x2', '\xE3', '\xE2', '\x3', '\x2', '\x2', '\x2', '\xE3', 
		'\xE4', '\x3', '\x2', '\x2', '\x2', '\xE4', '\xE6', '\x3', '\x2', '\x2', 
		'\x2', '\xE5', '\xD6', '\x3', '\x2', '\x2', '\x2', '\xE5', '\xDE', '\x3', 
		'\x2', '\x2', '\x2', '\xE6', '(', '\x3', '\x2', '\x2', '\x2', '\xE7', 
		'\xE9', '\x5', '#', '\x12', '\x2', '\xE8', '\xEA', '\a', '\"', '\x2', 
		'\x2', '\xE9', '\xE8', '\x3', '\x2', '\x2', '\x2', '\xE9', '\xEA', '\x3', 
		'\x2', '\x2', '\x2', '\xEA', '\xEB', '\x3', '\x2', '\x2', '\x2', '\xEB', 
		'\xED', '\a', '?', '\x2', '\x2', '\xEC', '\xEE', '\a', '\"', '\x2', '\x2', 
		'\xED', '\xEC', '\x3', '\x2', '\x2', '\x2', '\xED', '\xEE', '\x3', '\x2', 
		'\x2', '\x2', '\xEE', '\xEF', '\x3', '\x2', '\x2', '\x2', '\xEF', '\xF0', 
		'\x5', '+', '\x16', '\x2', '\xF0', '*', '\x3', '\x2', '\x2', '\x2', '\xF1', 
		'\xF5', '\x5', '-', '\x17', '\x2', '\xF2', '\xF5', '\x5', '%', '\x13', 
		'\x2', '\xF3', '\xF5', '\x5', '\x33', '\x1A', '\x2', '\xF4', '\xF1', '\x3', 
		'\x2', '\x2', '\x2', '\xF4', '\xF2', '\x3', '\x2', '\x2', '\x2', '\xF4', 
		'\xF3', '\x3', '\x2', '\x2', '\x2', '\xF5', '\xF7', '\x3', '\x2', '\x2', 
		'\x2', '\xF6', '\xF8', '\a', '\"', '\x2', '\x2', '\xF7', '\xF6', '\x3', 
		'\x2', '\x2', '\x2', '\xF7', '\xF8', '\x3', '\x2', '\x2', '\x2', '\xF8', 
		'\xFA', '\x3', '\x2', '\x2', '\x2', '\xF9', '\xF4', '\x3', '\x2', '\x2', 
		'\x2', '\xFA', '\xFB', '\x3', '\x2', '\x2', '\x2', '\xFB', '\xF9', '\x3', 
		'\x2', '\x2', '\x2', '\xFB', '\xFC', '\x3', '\x2', '\x2', '\x2', '\xFC', 
		',', '\x3', '\x2', '\x2', '\x2', '\xFD', '\xFF', '\a', '$', '\x2', '\x2', 
		'\xFE', '\x100', '\x5', '\x35', '\x1B', '\x2', '\xFF', '\xFE', '\x3', 
		'\x2', '\x2', '\x2', '\x100', '\x101', '\x3', '\x2', '\x2', '\x2', '\x101', 
		'\xFF', '\x3', '\x2', '\x2', '\x2', '\x101', '\x102', '\x3', '\x2', '\x2', 
		'\x2', '\x102', '\x103', '\x3', '\x2', '\x2', '\x2', '\x103', '\x104', 
		'\a', '$', '\x2', '\x2', '\x104', '.', '\x3', '\x2', '\x2', '\x2', '\x105', 
		'\x106', '\a', '\x42', '\x2', '\x2', '\x106', '\x107', '\x5', '#', '\x12', 
		'\x2', '\x107', '\x30', '\x3', '\x2', '\x2', '\x2', '\x108', '\x10B', 
		'\x5', ')', '\x15', '\x2', '\x109', '\x10B', '\x5', '+', '\x16', '\x2', 
		'\x10A', '\x108', '\x3', '\x2', '\x2', '\x2', '\x10A', '\x109', '\x3', 
		'\x2', '\x2', '\x2', '\x10B', '\x32', '\x3', '\x2', '\x2', '\x2', '\x10C', 
		'\x116', '\a', '*', '\x2', '\x2', '\x10D', '\x10F', '\x5', '\x31', '\x19', 
		'\x2', '\x10E', '\x110', '\a', '.', '\x2', '\x2', '\x10F', '\x10E', '\x3', 
		'\x2', '\x2', '\x2', '\x10F', '\x110', '\x3', '\x2', '\x2', '\x2', '\x110', 
		'\x112', '\x3', '\x2', '\x2', '\x2', '\x111', '\x113', '\a', '\"', '\x2', 
		'\x2', '\x112', '\x111', '\x3', '\x2', '\x2', '\x2', '\x112', '\x113', 
		'\x3', '\x2', '\x2', '\x2', '\x113', '\x115', '\x3', '\x2', '\x2', '\x2', 
		'\x114', '\x10D', '\x3', '\x2', '\x2', '\x2', '\x115', '\x118', '\x3', 
		'\x2', '\x2', '\x2', '\x116', '\x114', '\x3', '\x2', '\x2', '\x2', '\x116', 
		'\x117', '\x3', '\x2', '\x2', '\x2', '\x117', '\x119', '\x3', '\x2', '\x2', 
		'\x2', '\x118', '\x116', '\x3', '\x2', '\x2', '\x2', '\x119', '\x11A', 
		'\a', '+', '\x2', '\x2', '\x11A', '\x34', '\x3', '\x2', '\x2', '\x2', 
		'\x11B', '\x11D', '\n', '\x6', '\x2', '\x2', '\x11C', '\x11B', '\x3', 
		'\x2', '\x2', '\x2', '\x11D', '\x11E', '\x3', '\x2', '\x2', '\x2', '\x11E', 
		'\x11F', '\x3', '\x2', '\x2', '\x2', '\x11E', '\x11C', '\x3', '\x2', '\x2', 
		'\x2', '\x11F', '\x36', '\x3', '\x2', '\x2', '\x2', '!', '\x2', '^', 'v', 
		'\x8B', '\x9E', '\xA9', '\xB0', '\xB8', '\xBA', '\xBE', '\xC3', '\xC5', 
		'\xCC', '\xCE', '\xD2', '\xD6', '\xDC', '\xE0', '\xE3', '\xE5', '\xE9', 
		'\xED', '\xF4', '\xF7', '\xFB', '\x101', '\x10A', '\x10F', '\x112', '\x116', 
		'\x11E', '\x3', '\b', '\x2', '\x2',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
