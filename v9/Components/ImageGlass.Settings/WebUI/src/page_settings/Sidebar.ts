
export default class Sidebar {
  /**
   * Adds click events to sidebar menu.
   */
  static addEvents() {
    // navigation bar event
    const navItems = Array.from(document.querySelectorAll('input[name="nav"]'));
    for (let i = 0; i < navItems.length; i++) {
      const itemEl = navItems[i] as HTMLInputElement;

      itemEl.addEventListener('change', (e) => {
        const activeTabName = (e.target as HTMLInputElement).value;
        Sidebar.setActiveMenu(activeTabName);
      }, false);
    }
  }


  /**
   * Set the active menu for sidebar
   */
  static setActiveMenu(tabPageName: string) {
    // hide all tabs
    const allTabPages = queryAll('.tab-page');
    allTabPages.forEach(el => el.classList.remove('active'));

    // show the selected tab
    const tabPageEl = query(`.tab-page[tab="${tabPageName}"]`);
    tabPageEl?.classList.add('active');

    // select the active nav item
    const allNavItems = queryAll('input[type="radio"]');
    allNavItems.forEach((item: HTMLInputElement) => item.checked = false);
    const navItem = query(`input[type="radio"][value="${tabPageName}"]`) as HTMLInputElement;
    if (navItem) navItem.checked = true;
  }

}