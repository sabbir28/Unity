using System;

namespace UnityEngine
{
	// Token: 0x0200039C RID: 924
	public enum KeyCode
	{
		// Token: 0x04000CE6 RID: 3302
		None,
		// Token: 0x04000CE7 RID: 3303
		Backspace = 8,
		// Token: 0x04000CE8 RID: 3304
		Delete = 127,
		// Token: 0x04000CE9 RID: 3305
		Tab = 9,
		// Token: 0x04000CEA RID: 3306
		Clear = 12,
		// Token: 0x04000CEB RID: 3307
		Return,
		// Token: 0x04000CEC RID: 3308
		Pause = 19,
		// Token: 0x04000CED RID: 3309
		Escape = 27,
		// Token: 0x04000CEE RID: 3310
		Space = 32,
		// Token: 0x04000CEF RID: 3311
		Keypad0 = 256,
		// Token: 0x04000CF0 RID: 3312
		Keypad1,
		// Token: 0x04000CF1 RID: 3313
		Keypad2,
		// Token: 0x04000CF2 RID: 3314
		Keypad3,
		// Token: 0x04000CF3 RID: 3315
		Keypad4,
		// Token: 0x04000CF4 RID: 3316
		Keypad5,
		// Token: 0x04000CF5 RID: 3317
		Keypad6,
		// Token: 0x04000CF6 RID: 3318
		Keypad7,
		// Token: 0x04000CF7 RID: 3319
		Keypad8,
		// Token: 0x04000CF8 RID: 3320
		Keypad9,
		// Token: 0x04000CF9 RID: 3321
		KeypadPeriod,
		// Token: 0x04000CFA RID: 3322
		KeypadDivide,
		// Token: 0x04000CFB RID: 3323
		KeypadMultiply,
		// Token: 0x04000CFC RID: 3324
		KeypadMinus,
		// Token: 0x04000CFD RID: 3325
		KeypadPlus,
		// Token: 0x04000CFE RID: 3326
		KeypadEnter,
		// Token: 0x04000CFF RID: 3327
		KeypadEquals,
		// Token: 0x04000D00 RID: 3328
		UpArrow,
		// Token: 0x04000D01 RID: 3329
		DownArrow,
		// Token: 0x04000D02 RID: 3330
		RightArrow,
		// Token: 0x04000D03 RID: 3331
		LeftArrow,
		// Token: 0x04000D04 RID: 3332
		Insert,
		// Token: 0x04000D05 RID: 3333
		Home,
		// Token: 0x04000D06 RID: 3334
		End,
		// Token: 0x04000D07 RID: 3335
		PageUp,
		// Token: 0x04000D08 RID: 3336
		PageDown,
		// Token: 0x04000D09 RID: 3337
		F1,
		// Token: 0x04000D0A RID: 3338
		F2,
		// Token: 0x04000D0B RID: 3339
		F3,
		// Token: 0x04000D0C RID: 3340
		F4,
		// Token: 0x04000D0D RID: 3341
		F5,
		// Token: 0x04000D0E RID: 3342
		F6,
		// Token: 0x04000D0F RID: 3343
		F7,
		// Token: 0x04000D10 RID: 3344
		F8,
		// Token: 0x04000D11 RID: 3345
		F9,
		// Token: 0x04000D12 RID: 3346
		F10,
		// Token: 0x04000D13 RID: 3347
		F11,
		// Token: 0x04000D14 RID: 3348
		F12,
		// Token: 0x04000D15 RID: 3349
		F13,
		// Token: 0x04000D16 RID: 3350
		F14,
		// Token: 0x04000D17 RID: 3351
		F15,
		// Token: 0x04000D18 RID: 3352
		Alpha0 = 48,
		// Token: 0x04000D19 RID: 3353
		Alpha1,
		// Token: 0x04000D1A RID: 3354
		Alpha2,
		// Token: 0x04000D1B RID: 3355
		Alpha3,
		// Token: 0x04000D1C RID: 3356
		Alpha4,
		// Token: 0x04000D1D RID: 3357
		Alpha5,
		// Token: 0x04000D1E RID: 3358
		Alpha6,
		// Token: 0x04000D1F RID: 3359
		Alpha7,
		// Token: 0x04000D20 RID: 3360
		Alpha8,
		// Token: 0x04000D21 RID: 3361
		Alpha9,
		// Token: 0x04000D22 RID: 3362
		Exclaim = 33,
		// Token: 0x04000D23 RID: 3363
		DoubleQuote,
		// Token: 0x04000D24 RID: 3364
		Hash,
		// Token: 0x04000D25 RID: 3365
		Dollar,
		// Token: 0x04000D26 RID: 3366
		Ampersand = 38,
		// Token: 0x04000D27 RID: 3367
		Quote,
		// Token: 0x04000D28 RID: 3368
		LeftParen,
		// Token: 0x04000D29 RID: 3369
		RightParen,
		// Token: 0x04000D2A RID: 3370
		Asterisk,
		// Token: 0x04000D2B RID: 3371
		Plus,
		// Token: 0x04000D2C RID: 3372
		Comma,
		// Token: 0x04000D2D RID: 3373
		Minus,
		// Token: 0x04000D2E RID: 3374
		Period,
		// Token: 0x04000D2F RID: 3375
		Slash,
		// Token: 0x04000D30 RID: 3376
		Colon = 58,
		// Token: 0x04000D31 RID: 3377
		Semicolon,
		// Token: 0x04000D32 RID: 3378
		Less,
		// Token: 0x04000D33 RID: 3379
		Equals,
		// Token: 0x04000D34 RID: 3380
		Greater,
		// Token: 0x04000D35 RID: 3381
		Question,
		// Token: 0x04000D36 RID: 3382
		At,
		// Token: 0x04000D37 RID: 3383
		LeftBracket = 91,
		// Token: 0x04000D38 RID: 3384
		Backslash,
		// Token: 0x04000D39 RID: 3385
		RightBracket,
		// Token: 0x04000D3A RID: 3386
		Caret,
		// Token: 0x04000D3B RID: 3387
		Underscore,
		// Token: 0x04000D3C RID: 3388
		BackQuote,
		// Token: 0x04000D3D RID: 3389
		A,
		// Token: 0x04000D3E RID: 3390
		B,
		// Token: 0x04000D3F RID: 3391
		C,
		// Token: 0x04000D40 RID: 3392
		D,
		// Token: 0x04000D41 RID: 3393
		E,
		// Token: 0x04000D42 RID: 3394
		F,
		// Token: 0x04000D43 RID: 3395
		G,
		// Token: 0x04000D44 RID: 3396
		H,
		// Token: 0x04000D45 RID: 3397
		I,
		// Token: 0x04000D46 RID: 3398
		J,
		// Token: 0x04000D47 RID: 3399
		K,
		// Token: 0x04000D48 RID: 3400
		L,
		// Token: 0x04000D49 RID: 3401
		M,
		// Token: 0x04000D4A RID: 3402
		N,
		// Token: 0x04000D4B RID: 3403
		O,
		// Token: 0x04000D4C RID: 3404
		P,
		// Token: 0x04000D4D RID: 3405
		Q,
		// Token: 0x04000D4E RID: 3406
		R,
		// Token: 0x04000D4F RID: 3407
		S,
		// Token: 0x04000D50 RID: 3408
		T,
		// Token: 0x04000D51 RID: 3409
		U,
		// Token: 0x04000D52 RID: 3410
		V,
		// Token: 0x04000D53 RID: 3411
		W,
		// Token: 0x04000D54 RID: 3412
		X,
		// Token: 0x04000D55 RID: 3413
		Y,
		// Token: 0x04000D56 RID: 3414
		Z,
		// Token: 0x04000D57 RID: 3415
		Numlock = 300,
		// Token: 0x04000D58 RID: 3416
		CapsLock,
		// Token: 0x04000D59 RID: 3417
		ScrollLock,
		// Token: 0x04000D5A RID: 3418
		RightShift,
		// Token: 0x04000D5B RID: 3419
		LeftShift,
		// Token: 0x04000D5C RID: 3420
		RightControl,
		// Token: 0x04000D5D RID: 3421
		LeftControl,
		// Token: 0x04000D5E RID: 3422
		RightAlt,
		// Token: 0x04000D5F RID: 3423
		LeftAlt,
		// Token: 0x04000D60 RID: 3424
		LeftCommand = 310,
		// Token: 0x04000D61 RID: 3425
		LeftApple = 310,
		// Token: 0x04000D62 RID: 3426
		LeftWindows,
		// Token: 0x04000D63 RID: 3427
		RightCommand = 309,
		// Token: 0x04000D64 RID: 3428
		RightApple = 309,
		// Token: 0x04000D65 RID: 3429
		RightWindows = 312,
		// Token: 0x04000D66 RID: 3430
		AltGr,
		// Token: 0x04000D67 RID: 3431
		Help = 315,
		// Token: 0x04000D68 RID: 3432
		Print,
		// Token: 0x04000D69 RID: 3433
		SysReq,
		// Token: 0x04000D6A RID: 3434
		Break,
		// Token: 0x04000D6B RID: 3435
		Menu,
		// Token: 0x04000D6C RID: 3436
		Mouse0 = 323,
		// Token: 0x04000D6D RID: 3437
		Mouse1,
		// Token: 0x04000D6E RID: 3438
		Mouse2,
		// Token: 0x04000D6F RID: 3439
		Mouse3,
		// Token: 0x04000D70 RID: 3440
		Mouse4,
		// Token: 0x04000D71 RID: 3441
		Mouse5,
		// Token: 0x04000D72 RID: 3442
		Mouse6,
		// Token: 0x04000D73 RID: 3443
		JoystickButton0,
		// Token: 0x04000D74 RID: 3444
		JoystickButton1,
		// Token: 0x04000D75 RID: 3445
		JoystickButton2,
		// Token: 0x04000D76 RID: 3446
		JoystickButton3,
		// Token: 0x04000D77 RID: 3447
		JoystickButton4,
		// Token: 0x04000D78 RID: 3448
		JoystickButton5,
		// Token: 0x04000D79 RID: 3449
		JoystickButton6,
		// Token: 0x04000D7A RID: 3450
		JoystickButton7,
		// Token: 0x04000D7B RID: 3451
		JoystickButton8,
		// Token: 0x04000D7C RID: 3452
		JoystickButton9,
		// Token: 0x04000D7D RID: 3453
		JoystickButton10,
		// Token: 0x04000D7E RID: 3454
		JoystickButton11,
		// Token: 0x04000D7F RID: 3455
		JoystickButton12,
		// Token: 0x04000D80 RID: 3456
		JoystickButton13,
		// Token: 0x04000D81 RID: 3457
		JoystickButton14,
		// Token: 0x04000D82 RID: 3458
		JoystickButton15,
		// Token: 0x04000D83 RID: 3459
		JoystickButton16,
		// Token: 0x04000D84 RID: 3460
		JoystickButton17,
		// Token: 0x04000D85 RID: 3461
		JoystickButton18,
		// Token: 0x04000D86 RID: 3462
		JoystickButton19,
		// Token: 0x04000D87 RID: 3463
		Joystick1Button0,
		// Token: 0x04000D88 RID: 3464
		Joystick1Button1,
		// Token: 0x04000D89 RID: 3465
		Joystick1Button2,
		// Token: 0x04000D8A RID: 3466
		Joystick1Button3,
		// Token: 0x04000D8B RID: 3467
		Joystick1Button4,
		// Token: 0x04000D8C RID: 3468
		Joystick1Button5,
		// Token: 0x04000D8D RID: 3469
		Joystick1Button6,
		// Token: 0x04000D8E RID: 3470
		Joystick1Button7,
		// Token: 0x04000D8F RID: 3471
		Joystick1Button8,
		// Token: 0x04000D90 RID: 3472
		Joystick1Button9,
		// Token: 0x04000D91 RID: 3473
		Joystick1Button10,
		// Token: 0x04000D92 RID: 3474
		Joystick1Button11,
		// Token: 0x04000D93 RID: 3475
		Joystick1Button12,
		// Token: 0x04000D94 RID: 3476
		Joystick1Button13,
		// Token: 0x04000D95 RID: 3477
		Joystick1Button14,
		// Token: 0x04000D96 RID: 3478
		Joystick1Button15,
		// Token: 0x04000D97 RID: 3479
		Joystick1Button16,
		// Token: 0x04000D98 RID: 3480
		Joystick1Button17,
		// Token: 0x04000D99 RID: 3481
		Joystick1Button18,
		// Token: 0x04000D9A RID: 3482
		Joystick1Button19,
		// Token: 0x04000D9B RID: 3483
		Joystick2Button0,
		// Token: 0x04000D9C RID: 3484
		Joystick2Button1,
		// Token: 0x04000D9D RID: 3485
		Joystick2Button2,
		// Token: 0x04000D9E RID: 3486
		Joystick2Button3,
		// Token: 0x04000D9F RID: 3487
		Joystick2Button4,
		// Token: 0x04000DA0 RID: 3488
		Joystick2Button5,
		// Token: 0x04000DA1 RID: 3489
		Joystick2Button6,
		// Token: 0x04000DA2 RID: 3490
		Joystick2Button7,
		// Token: 0x04000DA3 RID: 3491
		Joystick2Button8,
		// Token: 0x04000DA4 RID: 3492
		Joystick2Button9,
		// Token: 0x04000DA5 RID: 3493
		Joystick2Button10,
		// Token: 0x04000DA6 RID: 3494
		Joystick2Button11,
		// Token: 0x04000DA7 RID: 3495
		Joystick2Button12,
		// Token: 0x04000DA8 RID: 3496
		Joystick2Button13,
		// Token: 0x04000DA9 RID: 3497
		Joystick2Button14,
		// Token: 0x04000DAA RID: 3498
		Joystick2Button15,
		// Token: 0x04000DAB RID: 3499
		Joystick2Button16,
		// Token: 0x04000DAC RID: 3500
		Joystick2Button17,
		// Token: 0x04000DAD RID: 3501
		Joystick2Button18,
		// Token: 0x04000DAE RID: 3502
		Joystick2Button19,
		// Token: 0x04000DAF RID: 3503
		Joystick3Button0,
		// Token: 0x04000DB0 RID: 3504
		Joystick3Button1,
		// Token: 0x04000DB1 RID: 3505
		Joystick3Button2,
		// Token: 0x04000DB2 RID: 3506
		Joystick3Button3,
		// Token: 0x04000DB3 RID: 3507
		Joystick3Button4,
		// Token: 0x04000DB4 RID: 3508
		Joystick3Button5,
		// Token: 0x04000DB5 RID: 3509
		Joystick3Button6,
		// Token: 0x04000DB6 RID: 3510
		Joystick3Button7,
		// Token: 0x04000DB7 RID: 3511
		Joystick3Button8,
		// Token: 0x04000DB8 RID: 3512
		Joystick3Button9,
		// Token: 0x04000DB9 RID: 3513
		Joystick3Button10,
		// Token: 0x04000DBA RID: 3514
		Joystick3Button11,
		// Token: 0x04000DBB RID: 3515
		Joystick3Button12,
		// Token: 0x04000DBC RID: 3516
		Joystick3Button13,
		// Token: 0x04000DBD RID: 3517
		Joystick3Button14,
		// Token: 0x04000DBE RID: 3518
		Joystick3Button15,
		// Token: 0x04000DBF RID: 3519
		Joystick3Button16,
		// Token: 0x04000DC0 RID: 3520
		Joystick3Button17,
		// Token: 0x04000DC1 RID: 3521
		Joystick3Button18,
		// Token: 0x04000DC2 RID: 3522
		Joystick3Button19,
		// Token: 0x04000DC3 RID: 3523
		Joystick4Button0,
		// Token: 0x04000DC4 RID: 3524
		Joystick4Button1,
		// Token: 0x04000DC5 RID: 3525
		Joystick4Button2,
		// Token: 0x04000DC6 RID: 3526
		Joystick4Button3,
		// Token: 0x04000DC7 RID: 3527
		Joystick4Button4,
		// Token: 0x04000DC8 RID: 3528
		Joystick4Button5,
		// Token: 0x04000DC9 RID: 3529
		Joystick4Button6,
		// Token: 0x04000DCA RID: 3530
		Joystick4Button7,
		// Token: 0x04000DCB RID: 3531
		Joystick4Button8,
		// Token: 0x04000DCC RID: 3532
		Joystick4Button9,
		// Token: 0x04000DCD RID: 3533
		Joystick4Button10,
		// Token: 0x04000DCE RID: 3534
		Joystick4Button11,
		// Token: 0x04000DCF RID: 3535
		Joystick4Button12,
		// Token: 0x04000DD0 RID: 3536
		Joystick4Button13,
		// Token: 0x04000DD1 RID: 3537
		Joystick4Button14,
		// Token: 0x04000DD2 RID: 3538
		Joystick4Button15,
		// Token: 0x04000DD3 RID: 3539
		Joystick4Button16,
		// Token: 0x04000DD4 RID: 3540
		Joystick4Button17,
		// Token: 0x04000DD5 RID: 3541
		Joystick4Button18,
		// Token: 0x04000DD6 RID: 3542
		Joystick4Button19,
		// Token: 0x04000DD7 RID: 3543
		Joystick5Button0,
		// Token: 0x04000DD8 RID: 3544
		Joystick5Button1,
		// Token: 0x04000DD9 RID: 3545
		Joystick5Button2,
		// Token: 0x04000DDA RID: 3546
		Joystick5Button3,
		// Token: 0x04000DDB RID: 3547
		Joystick5Button4,
		// Token: 0x04000DDC RID: 3548
		Joystick5Button5,
		// Token: 0x04000DDD RID: 3549
		Joystick5Button6,
		// Token: 0x04000DDE RID: 3550
		Joystick5Button7,
		// Token: 0x04000DDF RID: 3551
		Joystick5Button8,
		// Token: 0x04000DE0 RID: 3552
		Joystick5Button9,
		// Token: 0x04000DE1 RID: 3553
		Joystick5Button10,
		// Token: 0x04000DE2 RID: 3554
		Joystick5Button11,
		// Token: 0x04000DE3 RID: 3555
		Joystick5Button12,
		// Token: 0x04000DE4 RID: 3556
		Joystick5Button13,
		// Token: 0x04000DE5 RID: 3557
		Joystick5Button14,
		// Token: 0x04000DE6 RID: 3558
		Joystick5Button15,
		// Token: 0x04000DE7 RID: 3559
		Joystick5Button16,
		// Token: 0x04000DE8 RID: 3560
		Joystick5Button17,
		// Token: 0x04000DE9 RID: 3561
		Joystick5Button18,
		// Token: 0x04000DEA RID: 3562
		Joystick5Button19,
		// Token: 0x04000DEB RID: 3563
		Joystick6Button0,
		// Token: 0x04000DEC RID: 3564
		Joystick6Button1,
		// Token: 0x04000DED RID: 3565
		Joystick6Button2,
		// Token: 0x04000DEE RID: 3566
		Joystick6Button3,
		// Token: 0x04000DEF RID: 3567
		Joystick6Button4,
		// Token: 0x04000DF0 RID: 3568
		Joystick6Button5,
		// Token: 0x04000DF1 RID: 3569
		Joystick6Button6,
		// Token: 0x04000DF2 RID: 3570
		Joystick6Button7,
		// Token: 0x04000DF3 RID: 3571
		Joystick6Button8,
		// Token: 0x04000DF4 RID: 3572
		Joystick6Button9,
		// Token: 0x04000DF5 RID: 3573
		Joystick6Button10,
		// Token: 0x04000DF6 RID: 3574
		Joystick6Button11,
		// Token: 0x04000DF7 RID: 3575
		Joystick6Button12,
		// Token: 0x04000DF8 RID: 3576
		Joystick6Button13,
		// Token: 0x04000DF9 RID: 3577
		Joystick6Button14,
		// Token: 0x04000DFA RID: 3578
		Joystick6Button15,
		// Token: 0x04000DFB RID: 3579
		Joystick6Button16,
		// Token: 0x04000DFC RID: 3580
		Joystick6Button17,
		// Token: 0x04000DFD RID: 3581
		Joystick6Button18,
		// Token: 0x04000DFE RID: 3582
		Joystick6Button19,
		// Token: 0x04000DFF RID: 3583
		Joystick7Button0,
		// Token: 0x04000E00 RID: 3584
		Joystick7Button1,
		// Token: 0x04000E01 RID: 3585
		Joystick7Button2,
		// Token: 0x04000E02 RID: 3586
		Joystick7Button3,
		// Token: 0x04000E03 RID: 3587
		Joystick7Button4,
		// Token: 0x04000E04 RID: 3588
		Joystick7Button5,
		// Token: 0x04000E05 RID: 3589
		Joystick7Button6,
		// Token: 0x04000E06 RID: 3590
		Joystick7Button7,
		// Token: 0x04000E07 RID: 3591
		Joystick7Button8,
		// Token: 0x04000E08 RID: 3592
		Joystick7Button9,
		// Token: 0x04000E09 RID: 3593
		Joystick7Button10,
		// Token: 0x04000E0A RID: 3594
		Joystick7Button11,
		// Token: 0x04000E0B RID: 3595
		Joystick7Button12,
		// Token: 0x04000E0C RID: 3596
		Joystick7Button13,
		// Token: 0x04000E0D RID: 3597
		Joystick7Button14,
		// Token: 0x04000E0E RID: 3598
		Joystick7Button15,
		// Token: 0x04000E0F RID: 3599
		Joystick7Button16,
		// Token: 0x04000E10 RID: 3600
		Joystick7Button17,
		// Token: 0x04000E11 RID: 3601
		Joystick7Button18,
		// Token: 0x04000E12 RID: 3602
		Joystick7Button19,
		// Token: 0x04000E13 RID: 3603
		Joystick8Button0,
		// Token: 0x04000E14 RID: 3604
		Joystick8Button1,
		// Token: 0x04000E15 RID: 3605
		Joystick8Button2,
		// Token: 0x04000E16 RID: 3606
		Joystick8Button3,
		// Token: 0x04000E17 RID: 3607
		Joystick8Button4,
		// Token: 0x04000E18 RID: 3608
		Joystick8Button5,
		// Token: 0x04000E19 RID: 3609
		Joystick8Button6,
		// Token: 0x04000E1A RID: 3610
		Joystick8Button7,
		// Token: 0x04000E1B RID: 3611
		Joystick8Button8,
		// Token: 0x04000E1C RID: 3612
		Joystick8Button9,
		// Token: 0x04000E1D RID: 3613
		Joystick8Button10,
		// Token: 0x04000E1E RID: 3614
		Joystick8Button11,
		// Token: 0x04000E1F RID: 3615
		Joystick8Button12,
		// Token: 0x04000E20 RID: 3616
		Joystick8Button13,
		// Token: 0x04000E21 RID: 3617
		Joystick8Button14,
		// Token: 0x04000E22 RID: 3618
		Joystick8Button15,
		// Token: 0x04000E23 RID: 3619
		Joystick8Button16,
		// Token: 0x04000E24 RID: 3620
		Joystick8Button17,
		// Token: 0x04000E25 RID: 3621
		Joystick8Button18,
		// Token: 0x04000E26 RID: 3622
		Joystick8Button19
	}
}
