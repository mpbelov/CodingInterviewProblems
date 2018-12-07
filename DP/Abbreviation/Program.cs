﻿using System;
using ExecutionTimeTracker;

namespace Abbreviation {
    class Program {
        static void Main(string[] args) {
            TT.E(() => RecursionSolution.abbreviation("ABCdDEFghi", "ABCDEF"), "YES");

            TT.E(() => RecursionSolution.abbreviation("daBcd", "ABC"), "YES");
            TT.E(() => RecursionSolution.abbreviation("AbcDE", "ABDE"), "YES");
            TT.E(() => RecursionSolution.abbreviation("AbcDE", "AFDE"), "NO");
            TT.E(() => RecursionSolution.abbreviation(
                "RDWPJPAMKGRIWAPBZSYWALDBLDOFLWIQPMPLEMCJXKAENTLVYMSJNRJAQQPWAGVcGOHEWQYZDJRAXZOYDMNZJVUSJGKKKSYNCSFWKVNHOGVYULALKEBUNZHERDDOFCYWBUCJGbvqlddfazmmohcewjg",
                "RDPJPAMKGRIWAPBZSYWALDBLOFWIQPMPLEMCJXKAENTLVYMJNRJAQQPWAGVGOHEWQYZDJRAXZOYDMNZJVUSJGKKKSYNCSFWKVNHOGVYULALKEBUNZHERDOFCYWBUCJG"), "NO");

            TT.E(() => RecursionSolution.abbreviation(
                "MBQEVZPBjcbswirgrmkkfvfvcpiukuxlnxkkenqp",
                "MBQEVZP"), "NO");

            TT.E(() => RecursionSolution.abbreviation(
                "DINVMKSOfsVQByBnCWNKPRFRKMhFRSkNQRBVNTIKNBXRSXdADOSeNDcLWFCERZOLQjEZCEPKXPCYKCVKALNxBADQBFDQUpdqunpelxauyyrwtjpkwoxlrrqbjtxlkvkcajhpqhqeitafcsjxwtttzyhzvh",
                "DINVMKSOVQBBCWNKPRFRKMFRSNQRBVNTIKNBXRSXADOSNDLWFCERZOLQEZCEPKXPCYKCVKALNBADQBFDQU"), "YES");

            TT.E(() => RecursionSolution.abbreviation(
                "BFZZVHdQYHQEMNEFFRFJTQmNWHFVXRXlGTFNBqWQmyOWYWSTDSTMJRYHjBNTEWADLgHVgGIRGKFQSeCXNFNaIFAXOiQORUDROaNoJPXWZXIAABZKSZYFTDDTRGZXVZZNWNRHMvSTGEQCYAJSFvbqivjuqvuzafvwwifnrlcxgbjmigkms",
                "BFZZVHQYHQEMNEFFRFJTQNWHFVXRXGTFNBWQOWYWSTDSTMJRYHBNTEWADLHVGIRGKFQSCXNFNIFAXOQORUDRONJPXWZXIAABZKSZYFTDDTRGZXVZZNWNRHMSTGEQCYAJSF"), "YES");

            TT.E(() => RecursionSolution.abbreviation(
                "AQIUQVIPJDKYNEBPXFGVHCMFGvURORPRSTYQYJZCYJDNFRPRYTMZIsNDOJAOAGAEFRCDKUJBhdkedalbwoxxnoyowoxpdlelovibyiwat",
                "AQIUQVIPJDKYNEBPXFGVHCMFGURORPRSTYQYJZCYJDNFRPRYTMZINDOJAOAGAEFRCDKUJB"), "YES");

            TT.E(() => RecursionSolution.abbreviation(
                "HCPXJZTDXLWHYKHPPDFYFDJWTAETQLJCIIPVHMZHHOQTKONUHGYVKLXTFTBEMYAWXTCSwNJYALIGMIBDOWKIVStFATDOZCYSUCaATUWORPMTFPKTNHDSFWKRKBrXNBYICOZYDWLLElKKWTFAUSTZKFDCBQNYVcWKDHDMXJGFORwURHISYLBIZSOJXVRVBNPQLRJKIN",
                "HCPXJZTDXLWHYKHPPDFYFDJWTAETQLJCIIPVHMZHHOQTKONUHGYVKLXTFTBEMYAWXTCSNJYALIGMIBDOWKIVSFATDOZCYSUCATUWORPMTFPKTNHDSFWKRKBXNBYICOZYDWLLEKKWTFAUSTZKFDCBQNYVWKDHDMXJGFORURHISYLBIZSOJXVRVBNPQLRJKINIIOYB"), "NO");

            TT.E(() => RecursionSolution.abbreviation(
                "IZLAKtDFAITDNWMVQPDShQQFGTRIXDLNBQPZRpuRJMLLPHBMOWrNagJDPPREZSYBHIWKDHLkjPSEUWIVQYUfPPJYKCbPEKCSKBRIAAJTMDPAOLNWSQESOTRQZOFTMTTGTDTrWLPENHXHLDWAFNDZMIFlogtcddtulusydquboxquwmgcji",
                "IZLAKDFAITDNWMVQPDSQQFGTRIXDLNBQPZRRJMLLPHBMOWNJDPPREZSYBHIWKDHLPSEUWIVQYUPPJYKCPEKCSKBRIAAJTMDPAOLNWSQESOTRQZOFTMTTGTDTWLPENHXHLDWAFNDZMIF"), "YES");

            TT.E(() => RecursionSolution.abbreviation(
                "KRBPLVCTESRNPTCVNDMPTQYvFAWBGYPQHNXNAESRQMKFDZIEKVNZXSXKCFHQYCMMANPQFHWCEeNGOLWTUXZVMQNDZfRPLUFZcSTRLRYAZUKAZYXCVTNTNScSDFTBJSUKEQKZRDITZUCFVAPLCLTUWAXOnNHPYEOZDGWZPBJQBZEOFAeXTFJDWRHI",
                "KRBPVCTESRNPTCVNDMPTQYFWBGYPQHXNAESRQMFDZIEKVNZXSXKFHQYCMMANPQFHWCNGOLWTUXZVMQNDZRPLUFZSTRLRYAZUAZYXCVTNTNSSDTBJSUKEQKZRDITZUCFVAPCLTUWAXONHPYEOZDGWZPBJQBZEOAXTFJDWRHIPGQVCWODYNNV"), "NO");

            TT.E(() => RecursionSolution.abbreviation(
                "WOAECAAVWMSQMIMYMAPEVARGIZCTIVNLAgydhmrxwcjltpjdewxhxrtynyyuyhqwbpkwuqtpwmyhemjxvwoazumyfstoumreirdkwbmepwbrgmyhjgtqeltzxnwhbunvuoejnhfqcikggaqjgsoqhzrmu",
                "WOAECAAVWMSQMIMYMAPEVARGIZCTIVNLA"), "YES");

            TT.E(() => RecursionSolution.abbreviation(
                "RMPRWOBYTSjXGVJQPDQEHTWXMOGcHVWKATSWLBWPJBQTYKVHKMFKCYVVJXGLUEZTLSXChGBCAOAMiFEAPPAGWeMXXQAQTFCZGXKOGZLLUWTZDOYVWHIJZEIDOSHPwFWHYXCIZKTjKKVKQNDXMTCCBQMAGVCDPZOXHPSEQYthuqclzletakrqbzmaohadpog",
                "RMPRWOBYTSXGVJQPDQEHTWXMOGHVWKATSWLBWPJBQTYKVHKMFKCYVVJXGLUEZTLSXCGBCAOAMFEAPPAGWMXXQAQTFCZGXKOGZLLUWTZDOYVWHIJZEIDOSHPFWHYXCIZKTKKVKQNDXMTCCBQMAGVCDPZOXHPSEQY"), "YES");



            Console.WriteLine();
            Console.WriteLine();

            TT.E(() => RecursionSolution.abbreviation(
                "ERreEerREeerErrrrRRyeReErrerrereEEeRRErRrrereeeeerErereerReRereeeeCrreErREreeerrRrRERreeererererEeEEeerrerrereeRRerreeerrreRererereeSerEeeRereerrReErrrereErrerrrreererrsRRecerEreeRrrreRereerErrRRrrEeEererRrrreRerReRrereererereEeereEereesrERreReeerReErEeeeeRererReereRereerRrrRRerrerreeereEeeereerrEreeERreReRrEErRRerEereeeRreeErReerrEerEeEreerrTeeeEErreRErrerreeeeereeEeerERErRrereerreerRrrreerEreeRrErreeeRReRerrreerrEreerrerEeEeerreeeeEeerRrrerrsrerrereReREerEerrRerRErereRreerRreRReEeeeRerRereeerRerererrerrrreeReeERereeeesrrEerrrreeeeerrrrereeeeeerRrRrreeereRrreeseERrrrerReeeerreeeeereEerErrrRrreeeerRerrrrrErRreREeeerrrrrrrErrreerrRrereerrRrEEErsREeeerReEeErrrrRrRererereeererreereeRreerrerREeEReereerrrrrrereereeeerEeeeerreerSrReererrRereREreereErEReEReeeerrerEeeEeeRreeeRreeeEreeeeEreerrrEeereeerrrrERrRERReeerreEeJEEeSEeeeEeEeeRrRrrreeeRerrreerEreeererEereeeeRRrreReRrEerreEreeeerEErRrRrrrrerrereeEERErerreerrRrrreeeErEeErEreRrErRrErrreeeereeerrrrSeReeeeRerrrrerrEreerEeeeeeeerrreerreRerrREr",
                "ERREREERERRREERREERRERRREEEERRREREEECEREERRRERREEEERRREERRERRRRSERERERERERERRRRRREERREREERRREEERERRRRRRREREEESEREREREEEERRERERRRERRRRREEREREERERREERRERRERREREEEERRTEEEEREEREEEEEEEERERRRRERREERREREERRREREREEREEREEERRRERERERREEREERRERRERERERRRREEERRREERRRRREREREREEEEERRRRRRRREERRERRERRRERERRREEERRRRERRERERRRERRRREREERREEESREEREERRRERREEEERRERERREEREREEREERREEEEEERRRSRERREREEEERERREREEERRERREEEEEEEREEERERRERREREEJEESEEEEEEERRRREEREREEEEEERERRRRRRREEEEREERRREEREEERRREEEEREERRERRERRRSREEERERREERRRRER"), "YES");

            TT.E(() => RecursionSolution.abbreviation(
                "rReRRREreEreERRrreeeRrrrErReerreererEreEEseeEeErreEEereeerrerREreeeeerreeerrEEEReErrEeeeeREesrRerereRrreRreRRrreeEeEeERerrreweRrrEREEerRrrreRRrrEREreEerrrerrRerReeeerrErrreREreerrrRrreeereEseErreerrEreererRreereerrreeRrreEreerreRRErRERereEEerReReeEERrEEeeEeEeereeReeeeeReEerEREReseereRereEeeerEreEEereerEeEesrerrRerrererrerrReERrreeereeeeRerrEeeEerreRRrrRErseeErrEeeeerreeRErrRrRerrrrrerRErrerEeeeerrreerrreErrerEeeeeRRererrEReEeeererErErErRerrerErRrrRRrerrErrerrreErerrrreerreERReRerererErreRrererreRrReEERRereeeErEreeREEeeeErReRrreerRrRrreeRrRrEEEEereeerErrrerreErErrRRrreErReReRerrrerEereRreerererReERREeeeeeEeRerRerReeSrreesreeeeREeErresreeReeRrerrrrererrrrrreerrrrrrRREEerrerrErRRRereeerrREEreeEeerrEeeereeerReRerrrEEerrEEReEeerErerRrErSerErRRreERrerEeeerereEreEeerrREEEReereeRErerRrrrReeReEERrrerereereeErEEREeRSreRrRrreerrrReErReErerreerrrRrseererrerererrrreEeeRReRrerreeRerrRRerRPeeRerrreeRrrREereeEErererrRRRererrrerEEerrRrrReerRereeEerrsREEReEerEreEErrrsErreErereeerrrrRrrEeeErReEeReEeeeeEe",
                "RRRREERERREERRERREEEEEEEEEERRREREEERRREEEEEEREESRRRRRRREEERRRREERRERREREEREREEERERRREERRRRESERERRERRRREEEEERREREREEEERREEERREEEEEEREEEREEERERERREEREREEEEEERRREREERRREERRRRRREEREEEERERREREREERRREEREREERREREREEREERERERRRERERERERRRREERRRERERRRERRREERREEEEEREREEREEEERRRREERRRRERRREEEERERERERRRERRREEREEREERERREEEERRRESRESEREESRERRRRRRRERRRREEERERRRRERREEEEEEEEERRRRRREREEREEEERRESRRRRRREREEEEREERREEERRERRRREEERREEEEEERRSRRRERRERREERREERRRREERRRRRRRRRRPRRREEEEEEERRREEERRRRRERREEREEEEEREREEEERREEEREEREE"), "NO");

            TT.E(() => RecursionSolution.abbreviation(
                "yllyyyyllyyllyyyyllylyylyyyllllyyyyyyyllllylllylyylyllyylylyllyllllylyylylllyllyyllyyllylllyyyyyyllyyyyllllylyyyllllylyllylyyyllyllyyylylyyllllyllyyyyyllylyllllllllyyyllyllyyylyylyyyyyyyylyyyllyylyylyyllylyllllyyyyllyylyyyyyyyyylyyyyllyylyylllyylylyylyyylllylyllylyyyylyllylylllylllllyylylyylllllyylylyylllylyyyyllyyyyyyylyllyyllllyllyyylyyllllllyyllyylllyylllyllyyyyylyllyllyyyllylyyyyllyylyllyyyyyyyylllyyyyyylyylyylylyyyyyyylllyyyyylylyllllyyyylyyllylyyylyllyyllyyyyyyyyylylllylylllyllylllyllylyllylyllylyllyyllllylllllyyyylllylllyllyllyylllyyyyllyllylylylyylyylyylyyylylllylylyylllllyyyllylylyylylllllyylyllyyylylyyyylyylyllylyyllylyllyyyylyyyyylyyyylclyylylylylyllyyylyyyllllllllylyllyylylylllyylylylylyyylyllyylyyllyyyyyyylllyyyyylllylyyllyylylyylllyyylylyyyllyllyyllylyllyylylylyylylyyyylyllllyyyylylylylllllllllylyllyllylllyyylylyyllylllylyylyylylyyylylyylyyyyllyyllylylyllyylyllylyyyyllyllyllylyyyllllylylllyllllyylllyyyyylylyllyllylylylllyyyllllylylyllllyylyllyyyyylyyyyylyllylyyyyylyylelyy",
                "LLYYYLYYLLYYYLLYLYYLYYYLLLLYYYYYYYLLLLYLLLYLYYLLLYYLYLYLLYLLLLYLYYLYLYLLYYLLYYLLYLLLYYYYYYLLYYYYLLLLYYYYLLLLYLYLLYLYYYLLYLLYYYLYLLLLYLLYYYYYLYLYLLLLLLLLYYYLLYLLYYYYLYYYYYYYLYYYLLYYLYYLYYLYLYLLLLYYYYLLLYYYYYYYYYYYLLYYLYYLLYYLYLYYLYYYLLLYLYLYLYYLYLLYLYLLLYLLLLYYLYLYYLLLLYYLYYYLLLYLYYYLYYYYYYYLYLYYLLLYLLYYYYLLLLLLYYLLYYLLLYYLLLYLYYYYYLYLLYLYYYLLLYYYYLLYYLYLLYYYYYYLLLYYYYYYLYYLYYLYLYYYYYLLYYLYLYLLLLYYYYYLLYLYYYLYLLYLLYYYYYYYYYLYLLLYLYLLLYLLYLLLYLYLYLYLYLYLYLLYLLLLYLLLLLYYYYLLYLLLLLYLYYLLLYYYYLLYLYLYLLYYLYYLYYLYYYLYLLLYLYLYYLLLLLYYYLLYLYLYYLYLLLLYYLYLLYYYLYYYYLYYLLLLYYLYYLLYYYYLYYYYLYYYLLYYLYLYLYLYLYYYLYYYLLLLLLLLYLYLLYLYLYLLYYLYLYLYYYLYYYLYYLLYYYYYYYLLLYYYYYLLYLYYLLYYLYLYYLLLYYYLYLYYYLLYLLYLLYLYLYYLYLLYLYLYYYLYLLLLYYYYLYLYLYLLLLLLLLYLYLYLLYLLLYYYLYLYLLYLLYLYYLYYLYLYYYLYLYYLYYYYLLYYLLYLYLLYYLLLYYYYYYLLYLYLYYLLLYLYLLYLLLYYLLLYYYYYLYLYLLYLYLYLLLLYYYLLLLLYLYLLLLYYLYLLYYYYYLYYYYYLYLYLYYYYYLYYLLYY"), "YES");

            TT.E(() => RecursionSolution.abbreviation(
                "rararaarraraaraArarrrraaaqararraararrrrrrraarrrrarAarraaaarraaryrraaarrraararrardaaarrrRaaarrRraaRarrrrrarraraaaaarrrarrararraarrararrrraraaaaarrarrrrraaarrrrarrrarararraraaaaaarrrararrrraRaraAraaraARARaraarraarararaarrarrArAraAarrrrarrrrRrrraraaraaarrraraaarrrarrrraRarararrraraaraaarraaaaaAaaarrrararraaaaararRaaarraaaRrarraraaaaraaarrrarraarraaraaarrraaaaararrrwraraaaraarraaarrraaararaaarraraaaaarrrrarrrraaaarrarrrrrararararararrArarraaaaraAArrrarrrArrArrAraarRrraraaaAraaarrrarraarnraaaaarraaraaaaraaararaaarrarraarraararraaraAaraaaraaaaaaaaArrrrrarararaaraarRaarrrrraarrraraararaaararaarraAraaaaArrAraarArrararrraarrararrrarRarrrrrrarrrrarraarraarrarrraraaaaararAarararaarraaRararrArarAaraaarrrrraaaaarrrraararraaraaraauaraaaaraaarrrarrrrrraarroaraarrrrarraraRrrraaaaarrraarraarrrraararrrrhraarrarrraaaaarararRrarArrrraraaaarArraarraarraraaaraarrrAaaaraaraaaaraaararaArrrraaarrararrarrraararaarrrrrarArrarrrraaaraarrrraaRarrrrararaaararrrarrararaaarararraarRraaarRrrrrraraarrraraarraraarrRarar",
                "RARARAARRARAAAARRRRRAAAARARRAARARRRRRRRAARRRRARAARRAAAARRAARRRAAARRRAARARRARAAARRRRAAARRRRAARARRRRRARRARAAAAARRRARRARARRAARRARARRRRARAAAAARRARRRRRAAARRRRARRRARARARRARAAAAAARRRARARRRRARARAARAARAARARARAARRAARARARAARARRARARAAARRRRARRRRRRRRARAARAARRRARAAARRRARRRRARARARARRRARAARAAARRAAAAAAAAARRRARARAAAAARARRAARRAAARRARRARAAAARAARRRARRAARRAARAAARRRAAAAARARRRRARAAARAARRAAARRRAARARAAARRARAAAAARRRRARRRRAAAARRARRRRRARARARARARARRARARRAAAARAAARRRARRRARRARRARAARRRRAAAAARAAARRRRRAAAAAAARRAARAAARAARARAAARRARRAARRAARARRAARAAAAAARAAAAAAAAARRRRRAARARAARAARRARRRRRAARRARAARRAAARARAARRAARAAAAARRARAARARARARRRAARRARARRRARRARRRRRRARRRRARRAARRAARRARRRARAAAAARARAARARAAARRAARARARRARARAARAAARRRRRAAAARRRAARARRAAAARAAARAAAARAAARRRARRRRRRAARRARAARRRRARRARARRRRAAAAARRRAARRAARRRAARARRRRRARARRRAAAAARARARRRARARRRRARAAARARAARAARRAAAARAARRRAAAARARAAAARAARARAARRRRAAARRARRRARRRARARAARRRRRARARRARRRAAARAARRRRAAARRRRARARAAARARRRARARRAAARARARRARRRAARRRRRRRARAARRARAARRARAARRRARAR"), "NO");

            TT.E(() => RecursionSolution.abbreviation(
                "rrrrrrRRRrrrrrrRrrrrarrRrRrrrrrrrRrRrRrRrrrRrrrrrRrrrrrrRrrrrrRRrRrRRrrrrrrRrrRrrArrrRrrrarrrrrrrrrRrrRrrrrrRrRarrrrrrrrrrrrrRrrrrrrrrRrrrRrRrrrRrRrrrrRrrrrrrrrRrrrrrrrRsrrrrrRrRrrrarrRrrrrrRrrRrrRrrRrrarRrarrrrrrrrrrrrarrrRrrrRrRrrRrrrrrrrrrrRrrrrrRRRrRrrrrrrrrrrararrrrRrRrrrrrRrrRrrRrrrrrrrrRrrRrrrrrRrRrrRrrrrrrrrRrrrrrRRrrrrRrrrrrrRrrrrrRrrrrrRrrrRrrrRrrrrrarRrrRRrrrRrrrrRrrrrrraRrRrrrrrRarrrrrrrrrRrrrrrrrrRRrrarRrrrrrrrRrrrrrrrrrrrRrrRrrrrRrrarRrrrRrrRrrrrrRrrrrRrrrRrRrrrrRrRrrRrrrrrrrRrrrrrrrrrRrrrrrrrrrrrrrrrrrRrrrrRRrRrarrrRRrrrrrrrrrrrrrrrrRrrrrrrrrrrrrrRrrRrrrRrrrrrrrrRrrrrrrRrrRrrrrrRrrrrrRRrrRRrrrRrRRRRrrRrrrrRRARrrrrrrrrrrRRrrrrrRrrrrrRrrrRrrrrrrrrraRrRrrrrRrArrrrrrrRrrrrrrrrrrrrrrrrRrrrrrRRrrrkrrrrrrRRrarrRrrrrrrrRrrrrRRrRrrrrrrRrRrrrrrrrrrrRrrrrRrrarrRRrRrrrrrArrrRRrrrrrrRrrrrrrrrRrrrrRrrRrRRrrrrRrrrrrrRRrarrRrrRrkrrrrrrrrrrrrRArrrRrrrrRrrRrRRrrrrrRrRrrrRrrrrrrrrrrRrrrrRRRrrrrrRrRrRrrrRrArrrRrrRrrarrrrrrrRCrrrrrrrrrrrrrrrraRrrrrraarrrrrRrrRArrrrrrRrrrRRrrrrrrrrrrrrrrrrRrR",
                "RRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRARRRRRRRRRRRRRRRRRARRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRARRARRRRRRRRRRARRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRARARRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRARRRRRRRRARRRRRRRRRRRRRRRRRARRRRRRRRRRRRRRRRRRRRRRRRRRARRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRARRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRARRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRARRRRRRARRRRRRRRRRRRRRRRRRRRRRRRRRRRRRARRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRARRRRRRRRARRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRARRRRRRRRRRRRRRRRRARRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRARRRRRRRRRRRRRRRRRRRARRRRRAARRRRRRRRRRRRRRRRRRRRRRRRRRRRR"), "NO");

            TT.E(() => RecursionSolution.abbreviation(
                "bbbbbbbbbbbbbbbbbbbbbbobbBbbbobbbbbbtbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbtbbbotbbbbbbbbbbbbbbbbbbbbbbBbbbbbbbbbbbbbbbbbbbbbbbbobbbbbbbbbbbbbbbbbbtbbbbbbbbBbbbbbbbbbbbbbbbtbtbbbbbbBbbbbbbbbbbbobbbbbbbbbbbbbbbbbbobbbbbbbbbbobbbBbbbbbbbbbbtbbbbbbbbbbbtbbbbbbbobbbbbbbbbbbbobbbbbbbobbbbbbbbbbbbbbbbtbbbbbbbbbbbbbbbbbbBbbbbbbbbbobbbBbbtbbbbbbbbbbboBobbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbobbtbbbtbbbbbbbbbbbbbbbobbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbBtbbbbbbbbbbbbbbbbbbbbbbbtbbbbbbbbbbbbbbbbbbbbbbbbbbbtbbbbbbtbbbbcbbbbbbbbtbbbbbbbbbbbbbbbbobbbbbbbbbbbbbbbbbbbbbbbbBbbbbbbbbbbbbbbbbbbbbbbbbobbBbbbbbbbbbbbbbbbobbbbbbbbbbbbobbbbbbbbbBbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbobbbbbbbbbbbbbbbbbbbbbbBbbbbBbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbobbbbbbbbBbbbbbbbbbbbBbbBbbbbbbbbbbbbbbbbbbbbbbbbtbbbbbbbbbbbbbbbbbbbbbbbtbbbobbbbbbbbbbbbbbbbbbbtbbbbbbbbbbbbbbbbtbobBbbbbbbbbbbbBoobbbbbbbbbbbbbbbbbbbobbbbbbbobbbbbbbbobobbbtbbBbtbbbbtbbbbbbbbbbbbbbbbbbbbbtbbbobbtbbbbbb",
                "BBBBBBBBBBBBBBBBBBBBOBBBBOBBBBBBTBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBTBBBOBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBTBBBBBBBBBBBBBBBBBTBBBBBBBBBBBBBBOBBBBBBBBBBBBBOBBBBBBBBOBBBBBBBBBBBBBBBBBBBBTBBBBBBOBBBBBBBOBBOBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBTBBBBBBBBBOOBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBOBBTBBBTBBBBBBBBBBBBOBBBBBBBBBBBBBBBBBBBBBBBBBBBTBBBBBBBBBBBBBBBBBBTBBBBBBBBBBBBBBBBBBBBTBBBBTBBBBBBBBBBTBBBBBBBBBBBBBOBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBOBBBBBBBBBBBBBBBBBBBBBBBBBOBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBOBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBOBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBTBBBBBBBBBBBBBBBBBBBBTBBBOBBBBBBBBBBBBBTBBBBBBBBBBBBBBBTOBBBBBBBOBBBBBBBBBBBBBBBBOBBBBBBOBBBBBOBBTBBBBBBBBBBBBBBBBBBBBBBTBBBBBTBBBBB"), "NO");

            TT.E(() => RecursionSolution.abbreviation(
                "rrrarrrrrrrrrrrrrrrrrrrrrrrrrarrrrrrrrrrrrrrrrrrrrrrrrrrrrrarrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrbrrrrrrrrrrrrrrarrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrarrrrrrrrrrrrarrrrrrrrrrarrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrarrrrrrrrrrrrrrrrrrrrrrrorrrrrrrrrrrrrrrrrrrrrrrrrkrrrrrrrrrrrrrrrrrrarrrrrrrrrrrrrrrrrrrrarrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrarrrrarrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrmrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrarrrrrrrrrrrrrrrarrrrrrrrrrrrrrrrrrrrrrrrrrrarrrrrrrrrrrrrrrrrrarrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrarrrrrrrarrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrarrrrrrrrrrarrrrrrrrrrrrrrrrrrrrrrrarrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrraarrrrrarrararrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrarrrrrrrrrrrrrrrarrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrarrrrrrrrrrrrrrrrrrrrrrrrrrrrr",
                "RRRARRRRRRRRRRRRRRRRRRRRARRRRRRRRRRRRRRRRRRRRRRARRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRARRRRRRRRRARRRRRRRRARRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRARRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRARRRRRRRRRRRRRRRRRRARRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRARRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRARRRRRRRRRRRRRRRRRRRRRRRRARRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRARRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRARRRRRRRRRRRRRRRRRRARRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRARRRRARRARARRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRARRRRRRRRARRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRARRRRRRRRRRRRRRRRRRRRRRRRR"), "YES");

            TT.E(() => RecursionSolution.abbreviation(
                "bbbbbbbbbbbbbbbbbbbbbbbbbbbibbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbibbbbbbbibbbbbbbbbbbbbbbbbbbbubbbbbbbbbbbbbbibbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbtbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbtbbbbbbbbbbbttbbbtbbbbbbbbbbbbbbtbbbtbibbbbbbbbbbbbbbibbbbbbbbbbbbbbbbbbbbbbbbbbbbbbtbbbbbtbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbtibbbbbbibbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbtbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbubbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbibbbbbbbbbbbbbbbbbbbbibbbbbbbbbbbbbbbbbbbbbbbbbbiibbbibbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbibbbbbbbbbbbbbbbbbbbbbbbibbbbbbbibbibbbbbbbibbbbbbibbbbbbbbbibbbbibbbbbibbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbtbbbbbbbbbbbbbbbbbbbbibbbbbbbbbbbbbbbbtbbbbbbbbbbbbbbbbbbbbbbbbtbbbtbbbbtbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbtbtbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbibbbbbbbbbbbbbbbbbbbtbbbbibbbbbbbbbbbbbbbbbbbbbibbbbbbbbbbbbbbbbbibbbbbbbbbbbbbbbbb",
                "BBBBBBBBBBBBBBBBBBBBIBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBIBBBBBIBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBIBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBTBBBBBBBTTBBTBBBBBBBBBBBBBTBBBBBBBBBBBBBBIBBBBBBBBBBBBBBBBBBBBBBBBBBBTBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBTIBBBBBBIBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBTBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBIBBBBBBBBBBBBBBBBBBBBBIIBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBIBBBBBBBBBBBBBBBBBBBBBBBIBBBBBBBBIBBBBBIBBBBBBIBBBBBBBBIBBBBBBBBBBBBBBBBBBBBBBBBBBBBTBBBBBBBBBBBBBBBBBBBBBBBBBBBBBTBBBBBBBBBBBBBBBBBBBBTBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBTBTBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBIBBBBBBBBBBBBBBBBBBIBBBBBBBBBBBBBBBBIBBBBBBBBBBBBBBBIBBBBBBBBBBBBBBBB"), "YES");

            TT.E(() => RecursionSolution.abbreviation(
                "bbbbrtbbbbbbbbbbbbBbbbbbbobbbbbbbbbbrbbbbbbbsbbbbbbbbbbbbbbbbbbbbbbbsbbbbbbbbbobbbBbbrbbbbbbBbbbbbbbbbbbbbbbbbbbbbbbBsBbrbbbbbbbbbbbbbbbbbbbBbbbbbbbbbbbbBotbbbbbbbbbBbbbbbbbbbbbbbbbbbbrbbbbbBbbbbbbbbrbbbbbbbrbbbsbbbbobbbbbrbbbbbbbbBbbbbbbbbbbbbbbbbbbbbbbbbsbbbbbobbbbbbBbbbbBbbBbbbbbbbbbbbbbbbbbbbbbbtbbbbBbbbbbbbrbbbbbsbbbbbbrbbbobbbbbbbbbbbBbbbbbbbbbrbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbtbbbbbbbtbBbbsbbbbbbbbbbbbbbbbbbbbbbbbbbbtbbbbbbbbbbbbbbbrbbbbbbbbbbbbbbbbbbbbbbbbbbbBbbbbbbbbbbbbbbbbbbrbbbsbbBbsbbbbBbbbbbbbbbbbbbbbbbbbbbbbbbobBsBbbbbbbbbbbbrbbbbbbbbbbbbbbbbbsBbbbbbbbbbbbBbbbbbbbbbbbbbbrbbbbsbbbobtbbbbbbbbbbbObbbrbbbbBsbsbbbbbbbrbObbbobbbbbbbbobbbbtbtbosbbbbbbbbbbbbsbbObbbbbbrbbbbbBbbbbbrbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbsobBbbbbbbbbbbbbbbbbbbbbbbbbbbrBbbbobbbbobBbbbbbbbbbbbbbbrbbbbbbobbbbbbbbbbbBbBtbbbbbbrbbbbbbBbbbbbbtnbbbbbbBbbbbbtbtbbbbbbbbbbbbbrtbbbbbbbbbbrbbbbsoBobbbbbbbsbbbBbbbbbbbbbbbbbbobbsbbbbbbbbbbsbbobBbbbbbbbbbbosBbbbbbbbbbbbbbobbbbbobbbjbbbsbbBbbbbbbbbs",
                "BBBBRTBBBBBBBBBBBBBBBBOBBBBBBBBBRBBBBBBSBBBBBBBBBBBBBBBBBBBSBBBBBBBBOBBBBRBBBBBBBBBBBBBBBBBBBBBBBBBBSBRBBBBBBBBBBBBBBBBBBBBBBBBBBBBBOTBBBBBBBBBBBBBBBBBBBBBRBBBBBBBBBBBBRBBBRBBBSBBBOBRBBBBBBBBBBBBBBBBBBBBBBBBBBSBBBBBOBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBRBBSBBBBRBBBOBBBBBBBBBBBBBBBBRBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBTBBBTBBBSBBBBBBBBBBBBBBBBBBBBBBTBBBBBBBBBBBBBBRBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBRBBSBBBSBBBBBBBBBBBBBBBBBBBBBBBBBBBBBSBBBBBBBBRBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBRBBBSBBBOBTBBBBBBBBBBBRBBBBBSBBBBRBOBBOBBBBBOBTBTBOSBBBBBBBBBSBBBBBBBRBBBBBBBBBRBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBSOBBBBBBBBBBBBBBBBBBBBBBBBBBBOBBBOBBBBBBBBBBBRBBBOBBBBBBBBBBBBTBBBBBBRBBBBBBBBBBBBTBBBBBBBBBBTBBBBBBRTBBBBBBBBBRBBSOBOBBBBSBBBBBBBBBBBBBBBBOBBSBBBBBBBBBBOBBBBBBBBOBBBBBBBBBBBBBOBBBBOBBBBBBSBBBBBBB"), "NO");

            TT.E(() => RecursionSolution.abbreviation(
                "ssssssssssssssssssssiisssissstsssssssssssssssssssssssssstsssslssssgsissstsssssssssslssssssssssssisssssssssisssssitssssssstslsssssssssssssssssssssstsssssssssssssbssssstsssssspssssssssssssssssssssssssssspssssssssssssssssssspssssssssssitsslissssssssssssssssssssssssssssssssssssssssssssssisssssslsslsssstsssssssssssslsssssssisssssssssssstsssssisssssssssssslsssssssssssssssssssssssssssssssssssssssssssssssssslstsssssssssssissssssssisssssssssspsssssssssssssssssssssssspsssssissssssssissssssssstspsssssstssssssssssslssslspssssssssssssssssisssssssssssssssssisssspssssssssssisssssssssssssssssstsssssssissssssssssssssssspslsssssssssstssssspsssssnssssslsssssssssssssssssssssissssssssssssssstsslssssssssssspsssssssssssisssssssssssssssstssssssssstsssslssspsssssssssssssspississspssssssssssstsssslpssssssssissssssssssssssssssssssstssssssssssssisssssssssssssslsssssssssssstsssssssssssisssssssssssssssssssssssssssstssssissssssssssssssssssssssssssspslsssssssissssssissssssssssssssspssssssssssssssssssssssssssissssssls",
                "SSSSSSSSSSSSSSSSSIISSSSSTSSSSSSSSSSSSSSSSSSSSSSSSSSSLSSSSSISSTSSSSSSSSLSSSSSSSSSISSSSSSSSSSSITSSSSSTSLSSSSSSSSSSSSSSSSSSTSSSSSSSSSSSSSTSSSSSPSSSSSSSSSSSSSSSSSSSSSSSPSSSSSSSSSSSSSSSSSSSSITSSISSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSISSSSSLSSLSSSTSSSSSSSSSLSSSSSSISSSSSSSSSSSTSSSSISSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSLSTSSSSSSSSSSISSSSSSSSSSSSSSSPSSSSSSSSSSSSSSSSSSSPSSSSSSSSISSSSSSSSSPSSSSSSSSSSSSLSSSSPSSSSSSSSSSSSSSSSISSSSSSSSSSSSSSSISSSPSSSSSSSSISSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSPSLSSSSSSSTSSSPSSSSSSSLSSSSSSSSSSSSSSSSISSSSSSSSSSSSSSTSLSSSSSSSSSSSPSSSSSSSISSSSSSSSSSSSSTSSSSSSSSTSSSSSSSSSSSSSSSPISSISSSPSSSSSSSSSSTSSSSLPSSSSISSSSSSSSSSSSSSSSSSSSSSTSSSSSSSSSSSISSSSSSSSLSSSSSSSSTSSSSSSSSSSSSSSSSSSSSSSSSSSSSSTSSSSSSSSSSSSSSSSSSSSSSPLSSSSSSISSSSSISSSSSSSSSSPSSSSSSSSSSSSSSSSSSSSSISSSS"), "YES");

        }
    }
}
