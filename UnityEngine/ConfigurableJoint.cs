using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000164 RID: 356
	public sealed class ConfigurableJoint : Joint
	{
		// Token: 0x170005B7 RID: 1463
		// (get) Token: 0x060019AA RID: 6570 RVA: 0x000202EC File Offset: 0x0001E4EC
		// (set) Token: 0x060019AB RID: 6571 RVA: 0x0002030C File Offset: 0x0001E50C
		public Vector3 secondaryAxis
		{
			get
			{
				Vector3 result;
				this.INTERNAL_get_secondaryAxis(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_secondaryAxis(ref value);
			}
		}

		// Token: 0x060019AC RID: 6572
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_secondaryAxis(out Vector3 value);

		// Token: 0x060019AD RID: 6573
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_secondaryAxis(ref Vector3 value);

		// Token: 0x170005B8 RID: 1464
		// (get) Token: 0x060019AE RID: 6574
		// (set) Token: 0x060019AF RID: 6575
		public extern ConfigurableJointMotion xMotion { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170005B9 RID: 1465
		// (get) Token: 0x060019B0 RID: 6576
		// (set) Token: 0x060019B1 RID: 6577
		public extern ConfigurableJointMotion yMotion { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170005BA RID: 1466
		// (get) Token: 0x060019B2 RID: 6578
		// (set) Token: 0x060019B3 RID: 6579
		public extern ConfigurableJointMotion zMotion { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170005BB RID: 1467
		// (get) Token: 0x060019B4 RID: 6580
		// (set) Token: 0x060019B5 RID: 6581
		public extern ConfigurableJointMotion angularXMotion { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170005BC RID: 1468
		// (get) Token: 0x060019B6 RID: 6582
		// (set) Token: 0x060019B7 RID: 6583
		public extern ConfigurableJointMotion angularYMotion { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170005BD RID: 1469
		// (get) Token: 0x060019B8 RID: 6584
		// (set) Token: 0x060019B9 RID: 6585
		public extern ConfigurableJointMotion angularZMotion { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170005BE RID: 1470
		// (get) Token: 0x060019BA RID: 6586 RVA: 0x00020318 File Offset: 0x0001E518
		// (set) Token: 0x060019BB RID: 6587 RVA: 0x00020338 File Offset: 0x0001E538
		public SoftJointLimitSpring linearLimitSpring
		{
			get
			{
				SoftJointLimitSpring result;
				this.INTERNAL_get_linearLimitSpring(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_linearLimitSpring(ref value);
			}
		}

		// Token: 0x060019BC RID: 6588
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_linearLimitSpring(out SoftJointLimitSpring value);

		// Token: 0x060019BD RID: 6589
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_linearLimitSpring(ref SoftJointLimitSpring value);

		// Token: 0x170005BF RID: 1471
		// (get) Token: 0x060019BE RID: 6590 RVA: 0x00020344 File Offset: 0x0001E544
		// (set) Token: 0x060019BF RID: 6591 RVA: 0x00020364 File Offset: 0x0001E564
		public SoftJointLimitSpring angularXLimitSpring
		{
			get
			{
				SoftJointLimitSpring result;
				this.INTERNAL_get_angularXLimitSpring(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_angularXLimitSpring(ref value);
			}
		}

		// Token: 0x060019C0 RID: 6592
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_angularXLimitSpring(out SoftJointLimitSpring value);

		// Token: 0x060019C1 RID: 6593
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_angularXLimitSpring(ref SoftJointLimitSpring value);

		// Token: 0x170005C0 RID: 1472
		// (get) Token: 0x060019C2 RID: 6594 RVA: 0x00020370 File Offset: 0x0001E570
		// (set) Token: 0x060019C3 RID: 6595 RVA: 0x00020390 File Offset: 0x0001E590
		public SoftJointLimitSpring angularYZLimitSpring
		{
			get
			{
				SoftJointLimitSpring result;
				this.INTERNAL_get_angularYZLimitSpring(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_angularYZLimitSpring(ref value);
			}
		}

		// Token: 0x060019C4 RID: 6596
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_angularYZLimitSpring(out SoftJointLimitSpring value);

		// Token: 0x060019C5 RID: 6597
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_angularYZLimitSpring(ref SoftJointLimitSpring value);

		// Token: 0x170005C1 RID: 1473
		// (get) Token: 0x060019C6 RID: 6598 RVA: 0x0002039C File Offset: 0x0001E59C
		// (set) Token: 0x060019C7 RID: 6599 RVA: 0x000203BC File Offset: 0x0001E5BC
		public SoftJointLimit linearLimit
		{
			get
			{
				SoftJointLimit result;
				this.INTERNAL_get_linearLimit(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_linearLimit(ref value);
			}
		}

		// Token: 0x060019C8 RID: 6600
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_linearLimit(out SoftJointLimit value);

		// Token: 0x060019C9 RID: 6601
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_linearLimit(ref SoftJointLimit value);

		// Token: 0x170005C2 RID: 1474
		// (get) Token: 0x060019CA RID: 6602 RVA: 0x000203C8 File Offset: 0x0001E5C8
		// (set) Token: 0x060019CB RID: 6603 RVA: 0x000203E8 File Offset: 0x0001E5E8
		public SoftJointLimit lowAngularXLimit
		{
			get
			{
				SoftJointLimit result;
				this.INTERNAL_get_lowAngularXLimit(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_lowAngularXLimit(ref value);
			}
		}

		// Token: 0x060019CC RID: 6604
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_lowAngularXLimit(out SoftJointLimit value);

		// Token: 0x060019CD RID: 6605
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_lowAngularXLimit(ref SoftJointLimit value);

		// Token: 0x170005C3 RID: 1475
		// (get) Token: 0x060019CE RID: 6606 RVA: 0x000203F4 File Offset: 0x0001E5F4
		// (set) Token: 0x060019CF RID: 6607 RVA: 0x00020414 File Offset: 0x0001E614
		public SoftJointLimit highAngularXLimit
		{
			get
			{
				SoftJointLimit result;
				this.INTERNAL_get_highAngularXLimit(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_highAngularXLimit(ref value);
			}
		}

		// Token: 0x060019D0 RID: 6608
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_highAngularXLimit(out SoftJointLimit value);

		// Token: 0x060019D1 RID: 6609
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_highAngularXLimit(ref SoftJointLimit value);

		// Token: 0x170005C4 RID: 1476
		// (get) Token: 0x060019D2 RID: 6610 RVA: 0x00020420 File Offset: 0x0001E620
		// (set) Token: 0x060019D3 RID: 6611 RVA: 0x00020440 File Offset: 0x0001E640
		public SoftJointLimit angularYLimit
		{
			get
			{
				SoftJointLimit result;
				this.INTERNAL_get_angularYLimit(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_angularYLimit(ref value);
			}
		}

		// Token: 0x060019D4 RID: 6612
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_angularYLimit(out SoftJointLimit value);

		// Token: 0x060019D5 RID: 6613
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_angularYLimit(ref SoftJointLimit value);

		// Token: 0x170005C5 RID: 1477
		// (get) Token: 0x060019D6 RID: 6614 RVA: 0x0002044C File Offset: 0x0001E64C
		// (set) Token: 0x060019D7 RID: 6615 RVA: 0x0002046C File Offset: 0x0001E66C
		public SoftJointLimit angularZLimit
		{
			get
			{
				SoftJointLimit result;
				this.INTERNAL_get_angularZLimit(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_angularZLimit(ref value);
			}
		}

		// Token: 0x060019D8 RID: 6616
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_angularZLimit(out SoftJointLimit value);

		// Token: 0x060019D9 RID: 6617
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_angularZLimit(ref SoftJointLimit value);

		// Token: 0x170005C6 RID: 1478
		// (get) Token: 0x060019DA RID: 6618 RVA: 0x00020478 File Offset: 0x0001E678
		// (set) Token: 0x060019DB RID: 6619 RVA: 0x00020498 File Offset: 0x0001E698
		public Vector3 targetPosition
		{
			get
			{
				Vector3 result;
				this.INTERNAL_get_targetPosition(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_targetPosition(ref value);
			}
		}

		// Token: 0x060019DC RID: 6620
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_targetPosition(out Vector3 value);

		// Token: 0x060019DD RID: 6621
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_targetPosition(ref Vector3 value);

		// Token: 0x170005C7 RID: 1479
		// (get) Token: 0x060019DE RID: 6622 RVA: 0x000204A4 File Offset: 0x0001E6A4
		// (set) Token: 0x060019DF RID: 6623 RVA: 0x000204C4 File Offset: 0x0001E6C4
		public Vector3 targetVelocity
		{
			get
			{
				Vector3 result;
				this.INTERNAL_get_targetVelocity(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_targetVelocity(ref value);
			}
		}

		// Token: 0x060019E0 RID: 6624
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_targetVelocity(out Vector3 value);

		// Token: 0x060019E1 RID: 6625
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_targetVelocity(ref Vector3 value);

		// Token: 0x170005C8 RID: 1480
		// (get) Token: 0x060019E2 RID: 6626 RVA: 0x000204D0 File Offset: 0x0001E6D0
		// (set) Token: 0x060019E3 RID: 6627 RVA: 0x000204F0 File Offset: 0x0001E6F0
		public JointDrive xDrive
		{
			get
			{
				JointDrive result;
				this.INTERNAL_get_xDrive(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_xDrive(ref value);
			}
		}

		// Token: 0x060019E4 RID: 6628
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_xDrive(out JointDrive value);

		// Token: 0x060019E5 RID: 6629
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_xDrive(ref JointDrive value);

		// Token: 0x170005C9 RID: 1481
		// (get) Token: 0x060019E6 RID: 6630 RVA: 0x000204FC File Offset: 0x0001E6FC
		// (set) Token: 0x060019E7 RID: 6631 RVA: 0x0002051C File Offset: 0x0001E71C
		public JointDrive yDrive
		{
			get
			{
				JointDrive result;
				this.INTERNAL_get_yDrive(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_yDrive(ref value);
			}
		}

		// Token: 0x060019E8 RID: 6632
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_yDrive(out JointDrive value);

		// Token: 0x060019E9 RID: 6633
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_yDrive(ref JointDrive value);

		// Token: 0x170005CA RID: 1482
		// (get) Token: 0x060019EA RID: 6634 RVA: 0x00020528 File Offset: 0x0001E728
		// (set) Token: 0x060019EB RID: 6635 RVA: 0x00020548 File Offset: 0x0001E748
		public JointDrive zDrive
		{
			get
			{
				JointDrive result;
				this.INTERNAL_get_zDrive(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_zDrive(ref value);
			}
		}

		// Token: 0x060019EC RID: 6636
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_zDrive(out JointDrive value);

		// Token: 0x060019ED RID: 6637
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_zDrive(ref JointDrive value);

		// Token: 0x170005CB RID: 1483
		// (get) Token: 0x060019EE RID: 6638 RVA: 0x00020554 File Offset: 0x0001E754
		// (set) Token: 0x060019EF RID: 6639 RVA: 0x00020574 File Offset: 0x0001E774
		public Quaternion targetRotation
		{
			get
			{
				Quaternion result;
				this.INTERNAL_get_targetRotation(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_targetRotation(ref value);
			}
		}

		// Token: 0x060019F0 RID: 6640
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_targetRotation(out Quaternion value);

		// Token: 0x060019F1 RID: 6641
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_targetRotation(ref Quaternion value);

		// Token: 0x170005CC RID: 1484
		// (get) Token: 0x060019F2 RID: 6642 RVA: 0x00020580 File Offset: 0x0001E780
		// (set) Token: 0x060019F3 RID: 6643 RVA: 0x000205A0 File Offset: 0x0001E7A0
		public Vector3 targetAngularVelocity
		{
			get
			{
				Vector3 result;
				this.INTERNAL_get_targetAngularVelocity(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_targetAngularVelocity(ref value);
			}
		}

		// Token: 0x060019F4 RID: 6644
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_targetAngularVelocity(out Vector3 value);

		// Token: 0x060019F5 RID: 6645
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_targetAngularVelocity(ref Vector3 value);

		// Token: 0x170005CD RID: 1485
		// (get) Token: 0x060019F6 RID: 6646
		// (set) Token: 0x060019F7 RID: 6647
		public extern RotationDriveMode rotationDriveMode { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170005CE RID: 1486
		// (get) Token: 0x060019F8 RID: 6648 RVA: 0x000205AC File Offset: 0x0001E7AC
		// (set) Token: 0x060019F9 RID: 6649 RVA: 0x000205CC File Offset: 0x0001E7CC
		public JointDrive angularXDrive
		{
			get
			{
				JointDrive result;
				this.INTERNAL_get_angularXDrive(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_angularXDrive(ref value);
			}
		}

		// Token: 0x060019FA RID: 6650
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_angularXDrive(out JointDrive value);

		// Token: 0x060019FB RID: 6651
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_angularXDrive(ref JointDrive value);

		// Token: 0x170005CF RID: 1487
		// (get) Token: 0x060019FC RID: 6652 RVA: 0x000205D8 File Offset: 0x0001E7D8
		// (set) Token: 0x060019FD RID: 6653 RVA: 0x000205F8 File Offset: 0x0001E7F8
		public JointDrive angularYZDrive
		{
			get
			{
				JointDrive result;
				this.INTERNAL_get_angularYZDrive(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_angularYZDrive(ref value);
			}
		}

		// Token: 0x060019FE RID: 6654
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_angularYZDrive(out JointDrive value);

		// Token: 0x060019FF RID: 6655
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_angularYZDrive(ref JointDrive value);

		// Token: 0x170005D0 RID: 1488
		// (get) Token: 0x06001A00 RID: 6656 RVA: 0x00020604 File Offset: 0x0001E804
		// (set) Token: 0x06001A01 RID: 6657 RVA: 0x00020624 File Offset: 0x0001E824
		public JointDrive slerpDrive
		{
			get
			{
				JointDrive result;
				this.INTERNAL_get_slerpDrive(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_slerpDrive(ref value);
			}
		}

		// Token: 0x06001A02 RID: 6658
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_slerpDrive(out JointDrive value);

		// Token: 0x06001A03 RID: 6659
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_slerpDrive(ref JointDrive value);

		// Token: 0x170005D1 RID: 1489
		// (get) Token: 0x06001A04 RID: 6660
		// (set) Token: 0x06001A05 RID: 6661
		public extern JointProjectionMode projectionMode { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170005D2 RID: 1490
		// (get) Token: 0x06001A06 RID: 6662
		// (set) Token: 0x06001A07 RID: 6663
		public extern float projectionDistance { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170005D3 RID: 1491
		// (get) Token: 0x06001A08 RID: 6664
		// (set) Token: 0x06001A09 RID: 6665
		public extern float projectionAngle { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170005D4 RID: 1492
		// (get) Token: 0x06001A0A RID: 6666
		// (set) Token: 0x06001A0B RID: 6667
		public extern bool configuredInWorldSpace { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170005D5 RID: 1493
		// (get) Token: 0x06001A0C RID: 6668
		// (set) Token: 0x06001A0D RID: 6669
		public extern bool swapBodies { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }
	}
}
