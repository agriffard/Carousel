export function bindSwipe(element, dotNetRef) {
    if (!element) {
        return;
    }

    let touchStartX = 0;
    let touchEndX = 0;
    const threshold = 40;

    element.addEventListener('touchstart', (event) => {
        touchStartX = event.changedTouches[0].screenX;
    }, { passive: true });

    element.addEventListener('touchend', async (event) => {
        touchEndX = event.changedTouches[0].screenX;
        const delta = touchEndX - touchStartX;

        if (Math.abs(delta) < threshold) {
            return;
        }

        if (delta < 0) {
            await dotNetRef.invokeMethodAsync('SwipeLeft');
        } else {
            await dotNetRef.invokeMethodAsync('SwipeRight');
        }
    }, { passive: true });
}
