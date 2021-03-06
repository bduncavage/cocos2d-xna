using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cocos2D;

namespace tests
{
    public class Effect5 : EffectAdvanceTextLayer
    {
        public override void OnEnter()
        {
            base.OnEnter();

            //CCDirector::sharedDirector()->setProjection(CCDirectorProjection2D);

            CCActionInterval effect = new CCLiquid (2, new CCGridSize(32, 24), 1, 20);

            CCActionInterval stopEffect = (CCActionInterval)(new CCSequence(
                                                 effect,
                                                 new CCDelayTime (2),
                                                 new CCStopGrid()
                //					 [DelayTime::actionWithDuration:2],
                //					 [[effect copy] autorelease],
                                                 ));

            CCNode bg = GetChildByTag(EffectAdvanceScene.kTagBackground);
            bg.RunAction(stopEffect);
        }

        public override void OnExit()
        {
            base.OnExit();

            CCDirector.SharedDirector.Projection = CCDirectorProjection.Projection3D;
        }

        public override string title()
        {
            return "Test Stop-Copy-Restar";
        }
    }
}
