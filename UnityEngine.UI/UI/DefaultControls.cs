﻿using System;

namespace UnityEngine.UI
{
	// Token: 0x02000040 RID: 64
	public static class DefaultControls
	{
		// Token: 0x060001B1 RID: 433 RVA: 0x0000857C File Offset: 0x0000697C
		private static GameObject CreateUIElementRoot(string name, Vector2 size)
		{
			GameObject gameObject = new GameObject(name);
			RectTransform rectTransform = gameObject.AddComponent<RectTransform>();
			rectTransform.sizeDelta = size;
			return gameObject;
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x000085A8 File Offset: 0x000069A8
		private static GameObject CreateUIObject(string name, GameObject parent)
		{
			GameObject gameObject = new GameObject(name);
			gameObject.AddComponent<RectTransform>();
			DefaultControls.SetParentAndAlign(gameObject, parent);
			return gameObject;
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x000085D3 File Offset: 0x000069D3
		private static void SetDefaultTextValues(Text lbl)
		{
			lbl.color = DefaultControls.s_TextColor;
			lbl.AssignDefaultFont();
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x000085E8 File Offset: 0x000069E8
		private static void SetDefaultColorTransitionValues(Selectable slider)
		{
			ColorBlock colors = slider.colors;
			colors.highlightedColor = new Color(0.882f, 0.882f, 0.882f);
			colors.pressedColor = new Color(0.698f, 0.698f, 0.698f);
			colors.disabledColor = new Color(0.521f, 0.521f, 0.521f);
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x0000864E File Offset: 0x00006A4E
		private static void SetParentAndAlign(GameObject child, GameObject parent)
		{
			if (!(parent == null))
			{
				child.transform.SetParent(parent.transform, false);
				DefaultControls.SetLayerRecursively(child, parent.layer);
			}
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00008680 File Offset: 0x00006A80
		private static void SetLayerRecursively(GameObject go, int layer)
		{
			go.layer = layer;
			Transform transform = go.transform;
			for (int i = 0; i < transform.childCount; i++)
			{
				DefaultControls.SetLayerRecursively(transform.GetChild(i).gameObject, layer);
			}
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x000086C8 File Offset: 0x00006AC8
		public static GameObject CreatePanel(DefaultControls.Resources resources)
		{
			GameObject gameObject = DefaultControls.CreateUIElementRoot("Panel", DefaultControls.s_ThickElementSize);
			RectTransform component = gameObject.GetComponent<RectTransform>();
			component.anchorMin = Vector2.zero;
			component.anchorMax = Vector2.one;
			component.anchoredPosition = Vector2.zero;
			component.sizeDelta = Vector2.zero;
			Image image = gameObject.AddComponent<Image>();
			image.sprite = resources.background;
			image.type = Image.Type.Sliced;
			image.color = DefaultControls.s_PanelColor;
			return gameObject;
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x00008748 File Offset: 0x00006B48
		public static GameObject CreateButton(DefaultControls.Resources resources)
		{
			GameObject gameObject = DefaultControls.CreateUIElementRoot("Button", DefaultControls.s_ThickElementSize);
			GameObject gameObject2 = new GameObject("Text");
			gameObject2.AddComponent<RectTransform>();
			DefaultControls.SetParentAndAlign(gameObject2, gameObject);
			Image image = gameObject.AddComponent<Image>();
			image.sprite = resources.standard;
			image.type = Image.Type.Sliced;
			image.color = DefaultControls.s_DefaultSelectableColor;
			Button defaultColorTransitionValues = gameObject.AddComponent<Button>();
			DefaultControls.SetDefaultColorTransitionValues(defaultColorTransitionValues);
			Text text = gameObject2.AddComponent<Text>();
			text.text = "Button";
			text.alignment = TextAnchor.MiddleCenter;
			DefaultControls.SetDefaultTextValues(text);
			RectTransform component = gameObject2.GetComponent<RectTransform>();
			component.anchorMin = Vector2.zero;
			component.anchorMax = Vector2.one;
			component.sizeDelta = Vector2.zero;
			return gameObject;
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x0000880C File Offset: 0x00006C0C
		public static GameObject CreateText(DefaultControls.Resources resources)
		{
			GameObject gameObject = DefaultControls.CreateUIElementRoot("Text", DefaultControls.s_ThickElementSize);
			Text text = gameObject.AddComponent<Text>();
			text.text = "New Text";
			DefaultControls.SetDefaultTextValues(text);
			return gameObject;
		}

		// Token: 0x060001BA RID: 442 RVA: 0x0000884C File Offset: 0x00006C4C
		public static GameObject CreateImage(DefaultControls.Resources resources)
		{
			GameObject gameObject = DefaultControls.CreateUIElementRoot("Image", DefaultControls.s_ImageElementSize);
			gameObject.AddComponent<Image>();
			return gameObject;
		}

		// Token: 0x060001BB RID: 443 RVA: 0x0000887C File Offset: 0x00006C7C
		public static GameObject CreateRawImage(DefaultControls.Resources resources)
		{
			GameObject gameObject = DefaultControls.CreateUIElementRoot("RawImage", DefaultControls.s_ImageElementSize);
			gameObject.AddComponent<RawImage>();
			return gameObject;
		}

		// Token: 0x060001BC RID: 444 RVA: 0x000088AC File Offset: 0x00006CAC
		public static GameObject CreateSlider(DefaultControls.Resources resources)
		{
			GameObject gameObject = DefaultControls.CreateUIElementRoot("Slider", DefaultControls.s_ThinElementSize);
			GameObject gameObject2 = DefaultControls.CreateUIObject("Background", gameObject);
			GameObject gameObject3 = DefaultControls.CreateUIObject("Fill Area", gameObject);
			GameObject gameObject4 = DefaultControls.CreateUIObject("Fill", gameObject3);
			GameObject gameObject5 = DefaultControls.CreateUIObject("Handle Slide Area", gameObject);
			GameObject gameObject6 = DefaultControls.CreateUIObject("Handle", gameObject5);
			Image image = gameObject2.AddComponent<Image>();
			image.sprite = resources.background;
			image.type = Image.Type.Sliced;
			image.color = DefaultControls.s_DefaultSelectableColor;
			RectTransform component = gameObject2.GetComponent<RectTransform>();
			component.anchorMin = new Vector2(0f, 0.25f);
			component.anchorMax = new Vector2(1f, 0.75f);
			component.sizeDelta = new Vector2(0f, 0f);
			RectTransform component2 = gameObject3.GetComponent<RectTransform>();
			component2.anchorMin = new Vector2(0f, 0.25f);
			component2.anchorMax = new Vector2(1f, 0.75f);
			component2.anchoredPosition = new Vector2(-5f, 0f);
			component2.sizeDelta = new Vector2(-20f, 0f);
			Image image2 = gameObject4.AddComponent<Image>();
			image2.sprite = resources.standard;
			image2.type = Image.Type.Sliced;
			image2.color = DefaultControls.s_DefaultSelectableColor;
			RectTransform component3 = gameObject4.GetComponent<RectTransform>();
			component3.sizeDelta = new Vector2(10f, 0f);
			RectTransform component4 = gameObject5.GetComponent<RectTransform>();
			component4.sizeDelta = new Vector2(-20f, 0f);
			component4.anchorMin = new Vector2(0f, 0f);
			component4.anchorMax = new Vector2(1f, 1f);
			Image image3 = gameObject6.AddComponent<Image>();
			image3.sprite = resources.knob;
			image3.color = DefaultControls.s_DefaultSelectableColor;
			RectTransform component5 = gameObject6.GetComponent<RectTransform>();
			component5.sizeDelta = new Vector2(20f, 0f);
			Slider slider = gameObject.AddComponent<Slider>();
			slider.fillRect = gameObject4.GetComponent<RectTransform>();
			slider.handleRect = gameObject6.GetComponent<RectTransform>();
			slider.targetGraphic = image3;
			slider.direction = Slider.Direction.LeftToRight;
			DefaultControls.SetDefaultColorTransitionValues(slider);
			return gameObject;
		}

		// Token: 0x060001BD RID: 445 RVA: 0x00008AF8 File Offset: 0x00006EF8
		public static GameObject CreateScrollbar(DefaultControls.Resources resources)
		{
			GameObject gameObject = DefaultControls.CreateUIElementRoot("Scrollbar", DefaultControls.s_ThinElementSize);
			GameObject gameObject2 = DefaultControls.CreateUIObject("Sliding Area", gameObject);
			GameObject gameObject3 = DefaultControls.CreateUIObject("Handle", gameObject2);
			Image image = gameObject.AddComponent<Image>();
			image.sprite = resources.background;
			image.type = Image.Type.Sliced;
			image.color = DefaultControls.s_DefaultSelectableColor;
			Image image2 = gameObject3.AddComponent<Image>();
			image2.sprite = resources.standard;
			image2.type = Image.Type.Sliced;
			image2.color = DefaultControls.s_DefaultSelectableColor;
			RectTransform component = gameObject2.GetComponent<RectTransform>();
			component.sizeDelta = new Vector2(-20f, -20f);
			component.anchorMin = Vector2.zero;
			component.anchorMax = Vector2.one;
			RectTransform component2 = gameObject3.GetComponent<RectTransform>();
			component2.sizeDelta = new Vector2(20f, 20f);
			Scrollbar scrollbar = gameObject.AddComponent<Scrollbar>();
			scrollbar.handleRect = component2;
			scrollbar.targetGraphic = image2;
			DefaultControls.SetDefaultColorTransitionValues(scrollbar);
			return gameObject;
		}

		// Token: 0x060001BE RID: 446 RVA: 0x00008C00 File Offset: 0x00007000
		public static GameObject CreateToggle(DefaultControls.Resources resources)
		{
			GameObject gameObject = DefaultControls.CreateUIElementRoot("Toggle", DefaultControls.s_ThinElementSize);
			GameObject gameObject2 = DefaultControls.CreateUIObject("Background", gameObject);
			GameObject gameObject3 = DefaultControls.CreateUIObject("Checkmark", gameObject2);
			GameObject gameObject4 = DefaultControls.CreateUIObject("Label", gameObject);
			Toggle toggle = gameObject.AddComponent<Toggle>();
			toggle.isOn = true;
			Image image = gameObject2.AddComponent<Image>();
			image.sprite = resources.standard;
			image.type = Image.Type.Sliced;
			image.color = DefaultControls.s_DefaultSelectableColor;
			Image image2 = gameObject3.AddComponent<Image>();
			image2.sprite = resources.checkmark;
			Text text = gameObject4.AddComponent<Text>();
			text.text = "Toggle";
			DefaultControls.SetDefaultTextValues(text);
			toggle.graphic = image2;
			toggle.targetGraphic = image;
			DefaultControls.SetDefaultColorTransitionValues(toggle);
			RectTransform component = gameObject2.GetComponent<RectTransform>();
			component.anchorMin = new Vector2(0f, 1f);
			component.anchorMax = new Vector2(0f, 1f);
			component.anchoredPosition = new Vector2(10f, -10f);
			component.sizeDelta = new Vector2(20f, 20f);
			RectTransform component2 = gameObject3.GetComponent<RectTransform>();
			component2.anchorMin = new Vector2(0.5f, 0.5f);
			component2.anchorMax = new Vector2(0.5f, 0.5f);
			component2.anchoredPosition = Vector2.zero;
			component2.sizeDelta = new Vector2(20f, 20f);
			RectTransform component3 = gameObject4.GetComponent<RectTransform>();
			component3.anchorMin = new Vector2(0f, 0f);
			component3.anchorMax = new Vector2(1f, 1f);
			component3.offsetMin = new Vector2(23f, 1f);
			component3.offsetMax = new Vector2(-5f, -2f);
			return gameObject;
		}

		// Token: 0x060001BF RID: 447 RVA: 0x00008DE8 File Offset: 0x000071E8
		public static GameObject CreateInputField(DefaultControls.Resources resources)
		{
			GameObject gameObject = DefaultControls.CreateUIElementRoot("InputField", DefaultControls.s_ThickElementSize);
			GameObject gameObject2 = DefaultControls.CreateUIObject("Placeholder", gameObject);
			GameObject gameObject3 = DefaultControls.CreateUIObject("Text", gameObject);
			Image image = gameObject.AddComponent<Image>();
			image.sprite = resources.inputField;
			image.type = Image.Type.Sliced;
			image.color = DefaultControls.s_DefaultSelectableColor;
			InputField inputField = gameObject.AddComponent<InputField>();
			DefaultControls.SetDefaultColorTransitionValues(inputField);
			Text text = gameObject3.AddComponent<Text>();
			text.text = "";
			text.supportRichText = false;
			DefaultControls.SetDefaultTextValues(text);
			Text text2 = gameObject2.AddComponent<Text>();
			text2.text = "Enter text...";
			text2.fontStyle = FontStyle.Italic;
			Color color = text.color;
			color.a *= 0.5f;
			text2.color = color;
			RectTransform component = gameObject3.GetComponent<RectTransform>();
			component.anchorMin = Vector2.zero;
			component.anchorMax = Vector2.one;
			component.sizeDelta = Vector2.zero;
			component.offsetMin = new Vector2(10f, 6f);
			component.offsetMax = new Vector2(-10f, -7f);
			RectTransform component2 = gameObject2.GetComponent<RectTransform>();
			component2.anchorMin = Vector2.zero;
			component2.anchorMax = Vector2.one;
			component2.sizeDelta = Vector2.zero;
			component2.offsetMin = new Vector2(10f, 6f);
			component2.offsetMax = new Vector2(-10f, -7f);
			inputField.textComponent = text;
			inputField.placeholder = text2;
			return gameObject;
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x00008F84 File Offset: 0x00007384
		public static GameObject CreateDropdown(DefaultControls.Resources resources)
		{
			GameObject gameObject = DefaultControls.CreateUIElementRoot("Dropdown", DefaultControls.s_ThickElementSize);
			GameObject gameObject2 = DefaultControls.CreateUIObject("Label", gameObject);
			GameObject gameObject3 = DefaultControls.CreateUIObject("Arrow", gameObject);
			GameObject gameObject4 = DefaultControls.CreateUIObject("Template", gameObject);
			GameObject gameObject5 = DefaultControls.CreateUIObject("Viewport", gameObject4);
			GameObject gameObject6 = DefaultControls.CreateUIObject("Content", gameObject5);
			GameObject gameObject7 = DefaultControls.CreateUIObject("Item", gameObject6);
			GameObject gameObject8 = DefaultControls.CreateUIObject("Item Background", gameObject7);
			GameObject gameObject9 = DefaultControls.CreateUIObject("Item Checkmark", gameObject7);
			GameObject gameObject10 = DefaultControls.CreateUIObject("Item Label", gameObject7);
			GameObject gameObject11 = DefaultControls.CreateScrollbar(resources);
			gameObject11.name = "Scrollbar";
			DefaultControls.SetParentAndAlign(gameObject11, gameObject4);
			Scrollbar component = gameObject11.GetComponent<Scrollbar>();
			component.SetDirection(Scrollbar.Direction.BottomToTop, true);
			RectTransform component2 = gameObject11.GetComponent<RectTransform>();
			component2.anchorMin = Vector2.right;
			component2.anchorMax = Vector2.one;
			component2.pivot = Vector2.one;
			component2.sizeDelta = new Vector2(component2.sizeDelta.x, 0f);
			Text text = gameObject10.AddComponent<Text>();
			DefaultControls.SetDefaultTextValues(text);
			text.alignment = TextAnchor.MiddleLeft;
			Image image = gameObject8.AddComponent<Image>();
			image.color = new Color32(245, 245, 245, byte.MaxValue);
			Image image2 = gameObject9.AddComponent<Image>();
			image2.sprite = resources.checkmark;
			Toggle toggle = gameObject7.AddComponent<Toggle>();
			toggle.targetGraphic = image;
			toggle.graphic = image2;
			toggle.isOn = true;
			Image image3 = gameObject4.AddComponent<Image>();
			image3.sprite = resources.standard;
			image3.type = Image.Type.Sliced;
			ScrollRect scrollRect = gameObject4.AddComponent<ScrollRect>();
			scrollRect.content = (RectTransform)gameObject6.transform;
			scrollRect.viewport = (RectTransform)gameObject5.transform;
			scrollRect.horizontal = false;
			scrollRect.movementType = ScrollRect.MovementType.Clamped;
			scrollRect.verticalScrollbar = component;
			scrollRect.verticalScrollbarVisibility = ScrollRect.ScrollbarVisibility.AutoHideAndExpandViewport;
			scrollRect.verticalScrollbarSpacing = -3f;
			Mask mask = gameObject5.AddComponent<Mask>();
			mask.showMaskGraphic = false;
			Image image4 = gameObject5.AddComponent<Image>();
			image4.sprite = resources.mask;
			image4.type = Image.Type.Sliced;
			Text text2 = gameObject2.AddComponent<Text>();
			DefaultControls.SetDefaultTextValues(text2);
			text2.alignment = TextAnchor.MiddleLeft;
			Image image5 = gameObject3.AddComponent<Image>();
			image5.sprite = resources.dropdown;
			Image image6 = gameObject.AddComponent<Image>();
			image6.sprite = resources.standard;
			image6.color = DefaultControls.s_DefaultSelectableColor;
			image6.type = Image.Type.Sliced;
			Dropdown dropdown = gameObject.AddComponent<Dropdown>();
			dropdown.targetGraphic = image6;
			DefaultControls.SetDefaultColorTransitionValues(dropdown);
			dropdown.template = gameObject4.GetComponent<RectTransform>();
			dropdown.captionText = text2;
			dropdown.itemText = text;
			text.text = "Option A";
			dropdown.options.Add(new Dropdown.OptionData
			{
				text = "Option A"
			});
			dropdown.options.Add(new Dropdown.OptionData
			{
				text = "Option B"
			});
			dropdown.options.Add(new Dropdown.OptionData
			{
				text = "Option C"
			});
			dropdown.RefreshShownValue();
			RectTransform component3 = gameObject2.GetComponent<RectTransform>();
			component3.anchorMin = Vector2.zero;
			component3.anchorMax = Vector2.one;
			component3.offsetMin = new Vector2(10f, 6f);
			component3.offsetMax = new Vector2(-25f, -7f);
			RectTransform component4 = gameObject3.GetComponent<RectTransform>();
			component4.anchorMin = new Vector2(1f, 0.5f);
			component4.anchorMax = new Vector2(1f, 0.5f);
			component4.sizeDelta = new Vector2(20f, 20f);
			component4.anchoredPosition = new Vector2(-15f, 0f);
			RectTransform component5 = gameObject4.GetComponent<RectTransform>();
			component5.anchorMin = new Vector2(0f, 0f);
			component5.anchorMax = new Vector2(1f, 0f);
			component5.pivot = new Vector2(0.5f, 1f);
			component5.anchoredPosition = new Vector2(0f, 2f);
			component5.sizeDelta = new Vector2(0f, 150f);
			RectTransform component6 = gameObject5.GetComponent<RectTransform>();
			component6.anchorMin = new Vector2(0f, 0f);
			component6.anchorMax = new Vector2(1f, 1f);
			component6.sizeDelta = new Vector2(-18f, 0f);
			component6.pivot = new Vector2(0f, 1f);
			RectTransform component7 = gameObject6.GetComponent<RectTransform>();
			component7.anchorMin = new Vector2(0f, 1f);
			component7.anchorMax = new Vector2(1f, 1f);
			component7.pivot = new Vector2(0.5f, 1f);
			component7.anchoredPosition = new Vector2(0f, 0f);
			component7.sizeDelta = new Vector2(0f, 28f);
			RectTransform component8 = gameObject7.GetComponent<RectTransform>();
			component8.anchorMin = new Vector2(0f, 0.5f);
			component8.anchorMax = new Vector2(1f, 0.5f);
			component8.sizeDelta = new Vector2(0f, 20f);
			RectTransform component9 = gameObject8.GetComponent<RectTransform>();
			component9.anchorMin = Vector2.zero;
			component9.anchorMax = Vector2.one;
			component9.sizeDelta = Vector2.zero;
			RectTransform component10 = gameObject9.GetComponent<RectTransform>();
			component10.anchorMin = new Vector2(0f, 0.5f);
			component10.anchorMax = new Vector2(0f, 0.5f);
			component10.sizeDelta = new Vector2(20f, 20f);
			component10.anchoredPosition = new Vector2(10f, 0f);
			RectTransform component11 = gameObject10.GetComponent<RectTransform>();
			component11.anchorMin = Vector2.zero;
			component11.anchorMax = Vector2.one;
			component11.offsetMin = new Vector2(20f, 1f);
			component11.offsetMax = new Vector2(-10f, -2f);
			gameObject4.SetActive(false);
			return gameObject;
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x000095F4 File Offset: 0x000079F4
		public static GameObject CreateScrollView(DefaultControls.Resources resources)
		{
			GameObject gameObject = DefaultControls.CreateUIElementRoot("Scroll View", new Vector2(200f, 200f));
			GameObject gameObject2 = DefaultControls.CreateUIObject("Viewport", gameObject);
			GameObject gameObject3 = DefaultControls.CreateUIObject("Content", gameObject2);
			GameObject gameObject4 = DefaultControls.CreateScrollbar(resources);
			gameObject4.name = "Scrollbar Horizontal";
			DefaultControls.SetParentAndAlign(gameObject4, gameObject);
			RectTransform component = gameObject4.GetComponent<RectTransform>();
			component.anchorMin = Vector2.zero;
			component.anchorMax = Vector2.right;
			component.pivot = Vector2.zero;
			component.sizeDelta = new Vector2(0f, component.sizeDelta.y);
			GameObject gameObject5 = DefaultControls.CreateScrollbar(resources);
			gameObject5.name = "Scrollbar Vertical";
			DefaultControls.SetParentAndAlign(gameObject5, gameObject);
			gameObject5.GetComponent<Scrollbar>().SetDirection(Scrollbar.Direction.BottomToTop, true);
			RectTransform component2 = gameObject5.GetComponent<RectTransform>();
			component2.anchorMin = Vector2.right;
			component2.anchorMax = Vector2.one;
			component2.pivot = Vector2.one;
			component2.sizeDelta = new Vector2(component2.sizeDelta.x, 0f);
			RectTransform component3 = gameObject2.GetComponent<RectTransform>();
			component3.anchorMin = Vector2.zero;
			component3.anchorMax = Vector2.one;
			component3.sizeDelta = Vector2.zero;
			component3.pivot = Vector2.up;
			RectTransform component4 = gameObject3.GetComponent<RectTransform>();
			component4.anchorMin = Vector2.up;
			component4.anchorMax = Vector2.one;
			component4.sizeDelta = new Vector2(0f, 300f);
			component4.pivot = Vector2.up;
			ScrollRect scrollRect = gameObject.AddComponent<ScrollRect>();
			scrollRect.content = component4;
			scrollRect.viewport = component3;
			scrollRect.horizontalScrollbar = gameObject4.GetComponent<Scrollbar>();
			scrollRect.verticalScrollbar = gameObject5.GetComponent<Scrollbar>();
			scrollRect.horizontalScrollbarVisibility = ScrollRect.ScrollbarVisibility.AutoHideAndExpandViewport;
			scrollRect.verticalScrollbarVisibility = ScrollRect.ScrollbarVisibility.AutoHideAndExpandViewport;
			scrollRect.horizontalScrollbarSpacing = -3f;
			scrollRect.verticalScrollbarSpacing = -3f;
			Image image = gameObject.AddComponent<Image>();
			image.sprite = resources.background;
			image.type = Image.Type.Sliced;
			image.color = DefaultControls.s_PanelColor;
			Mask mask = gameObject2.AddComponent<Mask>();
			mask.showMaskGraphic = false;
			Image image2 = gameObject2.AddComponent<Image>();
			image2.sprite = resources.mask;
			image2.type = Image.Type.Sliced;
			return gameObject;
		}

		// Token: 0x040000D3 RID: 211
		private const float kWidth = 160f;

		// Token: 0x040000D4 RID: 212
		private const float kThickHeight = 30f;

		// Token: 0x040000D5 RID: 213
		private const float kThinHeight = 20f;

		// Token: 0x040000D6 RID: 214
		private static Vector2 s_ThickElementSize = new Vector2(160f, 30f);

		// Token: 0x040000D7 RID: 215
		private static Vector2 s_ThinElementSize = new Vector2(160f, 20f);

		// Token: 0x040000D8 RID: 216
		private static Vector2 s_ImageElementSize = new Vector2(100f, 100f);

		// Token: 0x040000D9 RID: 217
		private static Color s_DefaultSelectableColor = new Color(1f, 1f, 1f, 1f);

		// Token: 0x040000DA RID: 218
		private static Color s_PanelColor = new Color(1f, 1f, 1f, 0.392f);

		// Token: 0x040000DB RID: 219
		private static Color s_TextColor = new Color(0.19607843f, 0.19607843f, 0.19607843f, 1f);

		// Token: 0x02000041 RID: 65
		public struct Resources
		{
			// Token: 0x040000DC RID: 220
			public Sprite standard;

			// Token: 0x040000DD RID: 221
			public Sprite background;

			// Token: 0x040000DE RID: 222
			public Sprite inputField;

			// Token: 0x040000DF RID: 223
			public Sprite knob;

			// Token: 0x040000E0 RID: 224
			public Sprite checkmark;

			// Token: 0x040000E1 RID: 225
			public Sprite dropdown;

			// Token: 0x040000E2 RID: 226
			public Sprite mask;
		}
	}
}
