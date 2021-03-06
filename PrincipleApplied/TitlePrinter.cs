﻿using System;

using PrincipleApplied.Settings;

namespace PrincipleApplied
{
    public class TitlePrinter
    {
        private readonly IAppearanceSettings m_settings;

        public TitlePrinter(IAppearanceSettings settings)
        {
            m_settings = settings;
        }

        public void Print()
        {
            Console.WriteLine(m_settings.Title);
        }
    }
}
