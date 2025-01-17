﻿// © Anamnesis.
// Developed by W and A Walsh.
// Licensed under the MIT license.

namespace Anamnesis.GameData.ViewModels
{
	using System;
	using System.Windows.Media;
	using Anamnesis.Character.Items;
	using Anamnesis.Services;
	using Lumina;
	using Lumina.Excel;
	using Lumina.Excel.GeneratedSheets;

	using MediaColor = System.Windows.Media.Color;

	public class DyeViewModel : ExcelRowViewModel<Stain>, IDye
	{
		private IItem? item;

		public DyeViewModel(int key, ExcelSheet<Stain> sheet, GameData lumina)
			: base(key, sheet, lumina)
		{
		}

		public byte Id => (byte)this.Key;
		public override string Name => this.Value?.Name ?? "Unkown";
		public override string? Description => this.GetDyeItem()?.Description;
		public ImageSource? Icon => this.GetDyeItem()?.Icon;

		public Brush? Color
		{
			get
			{
				byte[]? colorBytes = BitConverter.GetBytes(this.Value.Color);

				if (colorBytes == null)
					return null;

				return new SolidColorBrush(MediaColor.FromRgb(colorBytes[2], colorBytes[1], colorBytes[0]));
			}
		}

		public IItem? GetDyeItem()
		{
			if (this.Key == 0)
				return null;

			if (GameDataService.Items == null)
				return null;

			if (this.item == null)
			{
				int itemKey = DyeToItemKey(this.Key);

				if (itemKey != 0)
				{
					this.item = GameDataService.Items.Get(itemKey);
				}
				else
				{
					this.item = null;
				}
			}

			return this.item;
		}

		private static int DyeToItemKey(int dyeKey)
		{
			switch (dyeKey)
			{
				case 1: return 5729;
				case 2: return 5730;
				case 3: return 5731;
				case 4: return 5732;
				case 5: return 5733;
				case 6: return 5734;
				case 7: return 5735;
				case 8: return 5736;
				case 9: return 5737;
				case 10: return 5738;
				case 11: return 5739;
				case 12: return 5740;
				case 13: return 5741;
				case 14: return 5742;
				case 15: return 5743;
				case 16: return 5744;
				case 17: return 5745;
				case 18: return 5746;
				case 19: return 5747;
				case 20: return 5748;
				case 21: return 5749;
				case 22: return 5750;
				case 23: return 5751;
				case 24: return 5752;
				case 25: return 5753;
				case 26: return 5754;
				case 27: return 5755;
				case 28: return 5756;
				case 29: return 5757;
				case 30: return 5758;
				case 31: return 5759;
				case 32: return 5760;
				case 33: return 5761;
				case 34: return 5762;
				case 35: return 5763;
				case 36: return 5764;
				case 37: return 5765;
				case 38: return 5766;
				case 39: return 5767;
				case 40: return 5768;
				case 41: return 5769;
				case 42: return 5770;
				case 43: return 5771;
				case 44: return 5772;
				case 45: return 5773;
				case 46: return 5774;
				case 47: return 5775;
				case 48: return 5776;
				case 49: return 5777;
				case 50: return 5778;
				case 51: return 5779;
				case 52: return 5780;
				case 53: return 5781;
				case 54: return 5782;
				case 55: return 5783;
				case 56: return 5784;
				case 57: return 5785;
				case 58: return 5786;
				case 59: return 5787;
				case 60: return 5788;
				case 61: return 5789;
				case 62: return 5790;
				case 63: return 5791;
				case 64: return 5792;
				case 65: return 5793;
				case 66: return 5794;
				case 67: return 5795;
				case 68: return 5796;
				case 69: return 5797;
				case 70: return 5798;
				case 71: return 5799;
				case 72: return 5800;
				case 73: return 5801;
				case 74: return 5802;
				case 75: return 5803;
				case 76: return 5804;
				case 77: return 5805;
				case 78: return 5806;
				case 79: return 5807;
				case 80: return 5808;
				case 81: return 5809;
				case 82: return 5810;
				case 83: return 5811;
				case 84: return 5812;
				case 85: return 5813;
				case 86: return 30116;
				case 87: return 30117;
				case 88: return 30118;
				case 89: return 30119;
				case 90: return 30120;
				case 91: return 30121;
				case 92: return 30122;
				case 93: return 30123;
				case 94: return 30124;
				case 101: return 8732;
				case 102: return 8733;
				case 103: return 8734;
				case 104: return 8735;
				case 105: return 8736;
				case 106: return 8737;
				case 107: return 8738;
				case 108: return 8739;
				case 109: return 8740;
				case 110: return 8741;
				case 111: return 8742;
				case 112: return 8743;
				case 113: return 8744;
				case 114: return 8745;
				case 115: return 8746;
				case 116: return 8747;
				case 117: return 8748;
				case 118: return 8749;
				case 119: return 8750;
				case 120: return 8751;

				default: return 0;
			}

			throw new Exception("Failed to find item key for dye key: " + dyeKey);
		}
	}
}
