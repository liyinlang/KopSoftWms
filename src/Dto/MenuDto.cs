﻿using System.Collections.Generic;

namespace YL.Core.Dto
{
    public class MenuDto
    {
        public string MenuId { get; set; }

        public string MenuName { get; set; }

        public List<MenuDto> Children { get; set; }
    }
}