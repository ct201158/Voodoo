public static string StringToBinary(string data) {
  StringBuilder sb = new StringBuilder();

  foreach(char c in data.ToCharArray()) {
    sb.Append(Convert.ToString(c, 2).PadLeft(8, '0'));
  }
  return sb.ToString();
}

public static string BinaryToString(string data) {
  List < Byte > byteList = new List < Byte > ();

  for (int i = 0; i < data.Length; i += 8) {
    byteList.Add(Convert.ToByte(data.Substring(i, 8), 2));
  }
  return Encoding.ASCII.GetString(byteList.ToArray());
}
private async void Encrypt(string input) {
    string binarytext = StringToBinary(richTextBox1.Text);

    binarytext = Regex.Replace(binarytext, ".{8}", "$0 ");
    var count = binarytext.Count(x => x == ' ');

    if (count % 2 == 0) {
      binarytext = binarytext + "==";
    } else {
      binarytext = binarytext + "=";
    }
    richTextBox1.Text = binarytext;
    richTextBox1.Text = Regex.Replace(richTextBox1.Text, " ", "");

    richTextBox1.Text = Regex.Replace(richTextBox1.Text, "0", "a"); //mainconv1
    richTextBox1.Text = Regex.Replace(richTextBox1.Text, "1", "b"); //mainconv2

    richTextBox1.Text = Regex.Replace(richTextBox1.Text, "aa", "c"); //secondaryconv1
    richTextBox1.Text = Regex.Replace(richTextBox1.Text, "bb", "d"); //secondaryconv2

    richTextBox1.Text = Regex.Replace(richTextBox1.Text, "cc", "e"); //thirdconv1
    richTextBox1.Text = Regex.Replace(richTextBox1.Text, "dd", "f"); //thirdconv2

    richTextBox1.Text = Regex.Replace(richTextBox1.Text, "ee", "g"); //thirdconv1
    richTextBox1.Text = Regex.Replace(richTextBox1.Text, "ff", "h"); //thirdconv2

    richTextBox1.Text = Regex.Replace(richTextBox1.Text, "gg", "i"); //thirdconv1
    richTextBox1.Text = Regex.Replace(richTextBox1.Text, "hh", "j"); //thirdconv2

    richTextBox1.Text = Regex.Replace(richTextBox1.Text, "ii", "k"); //fourthconv1
    richTextBox1.Text = Regex.Replace(richTextBox1.Text, "jj", "l"); //fourthconv2

    richTextBox1.Text = Regex.Replace(richTextBox1.Text, "kk", "m"); //fithconv1
    richTextBox1.Text = Regex.Replace(richTextBox1.Text, "ll", "n"); //fithconv2

    richTextBox1.Text = Regex.Replace(richTextBox1.Text, "mm", "o"); //sixthconv1
    richTextBox1.Text = Regex.Replace(richTextBox1.Text, "nn", "p"); //sixthconv2

    richTextBox1.Text = Regex.Replace(richTextBox1.Text, "oo", "q"); //seventhconv1
    richTextBox1.Text = Regex.Replace(richTextBox1.Text, "pp", "r"); //seventhconv2

    //EXTRA

    richTextBox1.Text = Regex.Replace(richTextBox1.Text, "bad", "s"); //
    richTextBox1.Text = Regex.Replace(richTextBox1.Text, "abc", "t"); //
    richTextBox1.Text = Regex.Replace(richTextBox1.Text, "ba", "u"); //
    richTextBox1.Text = Regex.Replace(richTextBox1.Text, "des", "v"); //
    richTextBox1.Text = Regex.Replace(richTextBox1.Text, "adc", "w"); //
    richTextBox1.Text = Regex.Replace(richTextBox1.Text, "cad", "x"); //
    richTextBox1.Text = Regex.Replace(richTextBox1.Text, "asd", "y"); //
    richTextBox1.Text = Regex.Replace(richTextBox1.Text, "ww", "z"); //

    // EXTRA NUMS

    richTextBox1.Text = Regex.Replace(richTextBox1.Text, "ads", "2"); //
    richTextBox1.Text = Regex.Replace(richTextBox1.Text, "cab", "3"); //
    richTextBox1.Text = Regex.Replace(richTextBox1.Text, "vub", "4"); //
    richTextBox1.Text = Regex.Replace(richTextBox1.Text, "bec", "5"); //
    richTextBox1.Text = Regex.Replace(richTextBox1.Text, "duu", "6"); //
    richTextBox1.Text = Regex.Replace(richTextBox1.Text, "suu", "7"); //
    richTextBox1.Text = Regex.Replace(richTextBox1.Text, "dab", "8"); //
    richTextBox1.Text = Regex.Replace(richTextBox1.Text, "dad", "9"); //

    //EXTRA SPECHARS

    richTextBox1.Text = Regex.Replace(richTextBox1.Text, "avc", "+"); //
    richTextBox1.Text = Regex.Replace(richTextBox1.Text, "dcd", "-"); //
    richTextBox1.Text = Regex.Replace(richTextBox1.Text, "fef", "&"); //
    richTextBox1.Text = Regex.Replace(richTextBox1.Text, "das", "^"); //
    richTextBox1.Text = Regex.Replace(richTextBox1.Text, "adb", "$"); //
    richTextBox1.Text = Regex.Replace(richTextBox1.Text, "wus", "@"); //
    richTextBox1.Text = Regex.Replace(richTextBox1.Text, "avc", "!"); //
    richTextBox1.Text = Regex.Replace(richTextBox1.Text, "bed", "/"); //

    //MORE SPECHARS

    richTextBox1.Text = Regex.Replace(richTextBox1.Text, "bc", "["); //
    richTextBox1.Text = Regex.Replace(richTextBox1.Text, "sa", "]"); //
    richTextBox1.Text = Regex.Replace(richTextBox1.Text, "bt", "~"); //
    richTextBox1.Text = Regex.Replace(richTextBox1.Text, "w@", @ "\"); //
      richTextBox1.Text = Regex.Replace(richTextBox1.Text, "td", "_"); //
      richTextBox1.Text = Regex.Replace(richTextBox1.Text, "ta", "{"); //
      richTextBox1.Text = Regex.Replace(richTextBox1.Text, "sc", "}"); //
      richTextBox1.Text = Regex.Replace(richTextBox1.Text, "fa", "."); //

      GC.Collect();
    }

    private void Decrypt(string input) {
      richTextBox1.Text = Regex.Replace(richTextBox1.Text, "\\[", "bc"); //bc
      richTextBox1.Text = Regex.Replace(richTextBox1.Text, "\\]", "sa"); //sa
      richTextBox1.Text = Regex.Replace(richTextBox1.Text, "~", "bt"); //bt
      richTextBox1.Text = Regex.Replace(richTextBox1.Text, "\\\\", @ "w@"); //w@
      richTextBox1.Text = Regex.Replace(richTextBox1.Text, "_", "td"); //td
      richTextBox1.Text = Regex.Replace(richTextBox1.Text, "{", "ta"); //ta
      richTextBox1.Text = Regex.Replace(richTextBox1.Text, "}", "sc"); //sc
      richTextBox1.Text = Regex.Replace(richTextBox1.Text, "\\.", "fa"); //fa

      richTextBox1.Text = Regex.Replace(richTextBox1.Text, "\\+", "avc"); //avc
      richTextBox1.Text = Regex.Replace(richTextBox1.Text, "-", "dcd"); //dcd
      richTextBox1.Text = Regex.Replace(richTextBox1.Text, "&", "fef"); //fef
      richTextBox1.Text = Regex.Replace(richTextBox1.Text, "\\^", "das"); //das
      richTextBox1.Text = Regex.Replace(richTextBox1.Text, "\\$", "adb"); //adb
      richTextBox1.Text = Regex.Replace(richTextBox1.Text, "@", "wus"); //wus
      richTextBox1.Text = Regex.Replace(richTextBox1.Text, "!", "avc"); //avc
      richTextBox1.Text = Regex.Replace(richTextBox1.Text, "/", "bed"); //bed

      richTextBox1.Text = Regex.Replace(richTextBox1.Text, "2", "ads"); //ads
      richTextBox1.Text = Regex.Replace(richTextBox1.Text, "3", "cab"); //cab
      richTextBox1.Text = Regex.Replace(richTextBox1.Text, "4", "vub"); //vub
      richTextBox1.Text = Regex.Replace(richTextBox1.Text, "5", "bec"); //bec
      richTextBox1.Text = Regex.Replace(richTextBox1.Text, "6", "duu"); //duu
      richTextBox1.Text = Regex.Replace(richTextBox1.Text, "7", "suu"); //suu
      richTextBox1.Text = Regex.Replace(richTextBox1.Text, "8", "dab"); //dab
      richTextBox1.Text = Regex.Replace(richTextBox1.Text, "9", "dad"); //dad

      richTextBox1.Text = Regex.Replace(richTextBox1.Text, "z", "ww"); //ww
      richTextBox1.Text = Regex.Replace(richTextBox1.Text, "t", "abc"); //abc
      richTextBox1.Text = Regex.Replace(richTextBox1.Text, "v", "des"); //des
      richTextBox1.Text = Regex.Replace(richTextBox1.Text, "w", "adc"); //adc
      richTextBox1.Text = Regex.Replace(richTextBox1.Text, "x", "cad"); //cad
      richTextBox1.Text = Regex.Replace(richTextBox1.Text, "y", "asd"); //asd
      richTextBox1.Text = Regex.Replace(richTextBox1.Text, "s", "bad"); //bad
      richTextBox1.Text = Regex.Replace(richTextBox1.Text, "u", "ba"); //ba

      richTextBox1.Text = Regex.Replace(richTextBox1.Text, "pp", "r");
      richTextBox1.Text = Regex.Replace(richTextBox1.Text, "oo", "q");

      richTextBox1.Text = Regex.Replace(richTextBox1.Text, "nn", "p");
      richTextBox1.Text = Regex.Replace(richTextBox1.Text, "mm", "o");

      richTextBox1.Text = Regex.Replace(richTextBox1.Text, "ll", "n");
      richTextBox1.Text = Regex.Replace(richTextBox1.Text, "kk", "m");

      richTextBox1.Text = Regex.Replace(richTextBox1.Text, "jj", "l");
      richTextBox1.Text = Regex.Replace(richTextBox1.Text, "ii", "k");

      richTextBox1.Text = Regex.Replace(richTextBox1.Text, "j", "hh");
      richTextBox1.Text = Regex.Replace(richTextBox1.Text, "i", "gg");

      richTextBox1.Text = Regex.Replace(richTextBox1.Text, "h", "ff");
      richTextBox1.Text = Regex.Replace(richTextBox1.Text, "g", "ee");

      richTextBox1.Text = Regex.Replace(richTextBox1.Text, "f", "dd");
      richTextBox1.Text = Regex.Replace(richTextBox1.Text, "e", "cc");

      richTextBox1.Text = Regex.Replace(richTextBox1.Text, "d", "bb");
      richTextBox1.Text = Regex.Replace(richTextBox1.Text, "c", "aa");

      richTextBox1.Text = Regex.Replace(richTextBox1.Text, "b", "1");
      richTextBox1.Text = Regex.Replace(richTextBox1.Text, "a", "0");

      //MessageBox.Show(richTextBox1.Text); //FOR DEBUG
      richTextBox1.Text = Regex.Replace(richTextBox1.Text, "=", "");
      richTextBox1.Text = BinaryToString(richTextBox1.Text);

      GC.Collect();
    }
