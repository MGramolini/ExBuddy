﻿namespace ExBuddy.OrderBotTags.Gather.Rotations
{
    using System.Threading.Tasks;

    [GatheringRotation("Collect115", 0, 24)]
    public class Collect115GatheringRotation : DefaultCollectGatheringRotation
    {
        public override async Task<bool> ExecuteRotation(GatherCollectableTag tag)
        {
            await Methodical(tag);

            await IncreaseChance(tag);

            return true;
        }

        public override int ShouldOverrideSelectedGatheringRotation(GatherCollectableTag tag)
        {
            // if we have a collectable && the collectable value is greater than or equal to 115: Priority 115
            if (tag.CollectableItem != null && tag.CollectableItem.Value >= 115)
            {
                return 115;
            }

            return -1;
        }
    }
}