using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public enum Locale
{
    en, pt
}

public static class Localization
{
    /*public static int Jason = 1;

    public static int Sum(int x, int y)
    {
        return x + y;
    }
    */

    private static Dictionary<Locale, Dictionary<string, string>> s_localizationTable;

    public static Locale s_currenLocale = Locale.en;

    public static Dictionary<string, string> s_currenLocalizationTable => s_localizationTable[s_currenLocale];

    static Localization()
    {
        Load();
    } 

    private static void Load()
    {
        var source = Resources.Load<TextAsset>("LocalizationSource");

        var lines = source.text.Split('\n');
        var header = lines[0].Split(';');

        var localeOrder = new List<Locale>(header.Length - 1);

        s_localizationTable = new Dictionary<Locale, Dictionary<string, string>>();

        for(int i =1; i < header.Length; i++)
        {
            var locale = (Locale)Enum.Parse(typeof(Locale), header[i]);
            localeOrder.Add(locale);
            s_localizationTable[locale] = new Dictionary<string, string>(lines.Length);
        }

        for(int index = 1; index < lines.Length; index++)
        {
            var entry = lines[index].Split(';');
            var key = entry[0];

            for(var i = 0; i< localeOrder.Count; i++)
            {
                var locale = localeOrder[i];
                s_localizationTable[locale][key] = entry[i + 1];
            }
        }
    }

    /*public static void PrintDictionaries()
    {
    }*/


}


