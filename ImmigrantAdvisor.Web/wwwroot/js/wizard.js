// Immigrant Advisor Wizard - Pure JavaScript
// Works without Blazor interactivity

document.addEventListener('DOMContentLoaded', function () {
    const totalSteps = 7;
    let currentStep = 0;
    const STORAGE_KEY = 'immigrant_advisor_form';
    const STEP_KEY = 'immigrant_advisor_step';
    const stepTitles = [
        'اطلاعات شخصی', 'تحصیلات و زبان', 'شغل و تخصص',
        'وضعیت مالی', 'سلامت و روان', 'اجتماعی و فرهنگی', 'اهداف و ترجیحات'
    ];
    const form = document.getElementById('wizardForm');

    // ═══ LocalStorage Persistence ═══
    function saveFormData() {
        if (!form) return;
        const data = {};
        const inputs = form.querySelectorAll('input, select, textarea');
        inputs.forEach(el => {
            if (!el.name) return;
            if (el.type === 'checkbox') {
                data[el.name] = el.checked;
            } else if (el.type === 'radio') {
                if (el.checked) data[el.name] = el.value;
            } else {
                data[el.name] = el.value;
            }
        });
        try {
            localStorage.setItem(STORAGE_KEY, JSON.stringify(data));
            localStorage.setItem(STEP_KEY, currentStep.toString());
        } catch (e) { /* storage full or unavailable */ }
    }

    function loadFormData() {
        if (!form) return false;
        try {
            const raw = localStorage.getItem(STORAGE_KEY);
            if (!raw) return false;
            const data = JSON.parse(raw);
            const inputs = form.querySelectorAll('input, select, textarea');
            inputs.forEach(el => {
                if (!el.name || !(el.name in data)) return;
                if (el.type === 'checkbox') {
                    el.checked = !!data[el.name];
                    // Trigger visual update for card checkboxes
                    const label = el.closest('label');
                    if (label && el.classList.contains('card-checkbox')) {
                        const activeClass = label.dataset.activeClass || 'border-indigo-500 bg-indigo-50';
                        const inactiveClass = label.dataset.inactiveClass || 'border-gray-200';
                        if (el.checked) {
                            label.classList.add(...activeClass.split(' '));
                            label.classList.remove(...inactiveClass.split(' '));
                        } else {
                            label.classList.remove(...activeClass.split(' '));
                            label.classList.add(...inactiveClass.split(' '));
                        }
                    }
                    if (label && el.classList.contains('goal-checkbox')) {
                        if (el.checked) {
                            label.classList.add('border-indigo-500', 'bg-indigo-50', 'text-indigo-700');
                            label.classList.remove('border-gray-200', 'text-gray-600');
                        } else {
                            label.classList.remove('border-indigo-500', 'bg-indigo-50', 'text-indigo-700');
                            label.classList.add('border-gray-200', 'text-gray-600');
                        }
                    }
                } else if (el.type === 'radio') {
                    el.checked = el.value === data[el.name];
                } else {
                    el.value = data[el.name];
                }
            });

            // Restore conditional fields visibility
            const maritalSelect = document.getElementById('MaritalStatus');
            if (maritalSelect) {
                const marriedFields = document.getElementById('marriedFields');
                if (marriedFields) marriedFields.style.display = maritalSelect.value === 'Married' ? 'block' : 'none';
            }
            const relativesCb = document.getElementById('HasRelativesAbroad');
            if (relativesCb) {
                const f = document.getElementById('relativesFields');
                if (f) f.style.display = relativesCb.checked ? 'block' : 'none';
            }
            const numChildren = document.getElementById('NumberOfChildren');
            if (numChildren) {
                const f = document.getElementById('childrenFields');
                if (f) f.style.display = parseInt(numChildren.value) > 0 ? 'block' : 'none';
            }

            // Restore step
            const savedStep = localStorage.getItem(STEP_KEY);
            if (savedStep !== null) {
                currentStep = Math.min(parseInt(savedStep) || 0, totalSteps - 1);
            }
            return true;
        } catch (e) { return false; }
    }

    function clearFormData() {
        try {
            localStorage.removeItem(STORAGE_KEY);
            localStorage.removeItem(STEP_KEY);
        } catch (e) { /* ignore */ }
    }

    // Auto-save on every input change
    if (form) {
        form.addEventListener('input', function (e) {
            if (e.target.name) saveFormData();
        });
        form.addEventListener('change', function (e) {
            if (e.target.name) saveFormData();
        });
    }

    // Clear cache after successful form submission
    if (form) {
        form.addEventListener('submit', function () {
            clearFormData();
        });
    }

    // Load saved data
    const restored = loadFormData();

    // Hide all steps except current
    document.querySelectorAll('.wizard-step-content').forEach((el, i) => {
        el.style.display = i === currentStep ? 'block' : 'none';
    });

    // Goal toggle
    document.querySelectorAll('.goal-checkbox').forEach(cb => {
        cb.addEventListener('change', function () {
            const label = this.closest('label');
            if (this.checked) {
                label.classList.add('border-indigo-500', 'bg-indigo-50', 'text-indigo-700');
                label.classList.remove('border-gray-200', 'text-gray-600');
            } else {
                label.classList.remove('border-indigo-500', 'bg-indigo-50', 'text-indigo-700');
                label.classList.add('border-gray-200', 'text-gray-600');
            }
        });
    });

    // Checkbox card toggle
    document.querySelectorAll('.card-checkbox').forEach(cb => {
        cb.addEventListener('change', function () {
            const label = this.closest('label');
            if (!label) return;
            const activeClass = label.dataset.activeClass || 'border-indigo-500 bg-indigo-50';
            const inactiveClass = label.dataset.inactiveClass || 'border-gray-200';
            if (this.checked) {
                label.classList.add(...activeClass.split(' '));
                label.classList.remove(...inactiveClass.split(' '));
            } else {
                label.classList.remove(...activeClass.split(' '));
                label.classList.add(...inactiveClass.split(' '));
            }
        });
    });

    // Conditional fields
    const maritalSelect = document.getElementById('MaritalStatus');
    if (maritalSelect) {
        maritalSelect.addEventListener('change', function () {
            const marriedFields = document.getElementById('marriedFields');
            if (marriedFields) {
                marriedFields.style.display = this.value === 'Married' ? 'block' : 'none';
            }
        });
    }

    const relativesCb = document.getElementById('HasRelativesAbroad');
    if (relativesCb) {
        relativesCb.addEventListener('change', function () {
            const f = document.getElementById('relativesFields');
            if (f) f.style.display = this.checked ? 'block' : 'none';
        });
    }

    const numChildren = document.getElementById('NumberOfChildren');
    if (numChildren) {
        numChildren.addEventListener('input', function () {
            const f = document.getElementById('childrenFields');
            if (f) f.style.display = parseInt(this.value) > 0 ? 'block' : 'none';
        });
    }

    function updateUI() {
        // Show/hide steps
        document.querySelectorAll('.wizard-step-content').forEach((el, i) => {
            el.style.display = i === currentStep ? 'block' : 'none';
        });

        // Update stepper circles
        document.querySelectorAll('.step-circle').forEach((el, i) => {
            el.classList.remove('bg-indigo-600', 'text-white', 'shadow-lg', 'shadow-indigo-200', 'scale-110',
                'bg-green-500', 'bg-gray-100', 'text-gray-400');
            if (i === currentStep) {
                el.classList.add('bg-indigo-600', 'text-white', 'shadow-lg', 'shadow-indigo-200', 'scale-110');
                el.innerHTML = (i + 1).toString();
            } else if (i < currentStep) {
                el.classList.add('bg-green-500', 'text-white');
                el.innerHTML = '<svg class="w-5 h-5" fill="none" stroke="currentColor" viewBox="0 0 24 24"><path stroke-linecap="round" stroke-linejoin="round" stroke-width="2.5" d="M5 13l4 4L19 7"/></svg>';
            } else {
                el.classList.add('bg-gray-100', 'text-gray-400');
                el.innerHTML = (i + 1).toString();
            }
        });

        // Update progress bars
        document.querySelectorAll('.step-progress').forEach((el, i) => {
            if (i < currentStep) {
                el.classList.remove('bg-gray-100', 'w-0');
                el.classList.add('bg-green-500', 'w-full');
            } else {
                el.classList.remove('bg-green-500', 'w-full');
                el.classList.add('bg-gray-100', 'w-0');
            }
        });

        // Update step title
        const titleEl = document.getElementById('stepTitle');
        if (titleEl) titleEl.textContent = stepTitles[currentStep];
        const counterEl = document.getElementById('stepCounter');
        if (counterEl) counterEl.textContent = `مرحله ${currentStep + 1} از ${totalSteps}`;

        // Update buttons
        const prevBtn = document.getElementById('prevBtn');
        const nextBtn = document.getElementById('nextBtn');
        const submitArea = document.getElementById('submitArea');

        if (prevBtn) prevBtn.style.display = currentStep > 0 ? 'flex' : 'none';
        if (nextBtn) nextBtn.style.display = currentStep < totalSteps - 1 ? 'flex' : 'none';
        if (submitArea) submitArea.style.display = currentStep === totalSteps - 1 ? 'flex' : 'none';
    }

    // Navigation
    const prevBtn = document.getElementById('prevBtn');
    const nextBtn = document.getElementById('nextBtn');

    if (nextBtn) nextBtn.addEventListener('click', function () {
        if (currentStep < totalSteps - 1) { currentStep++; saveFormData(); updateUI(); window.scrollTo({ top: 0, behavior: 'smooth' }); }
    });

    if (prevBtn) prevBtn.addEventListener('click', function () {
        if (currentStep > 0) { currentStep--; saveFormData(); updateUI(); window.scrollTo({ top: 0, behavior: 'smooth' }); }
    });

    // Stepper circle clicks (only go back)
    document.querySelectorAll('.step-circle-btn').forEach((btn, i) => {
        btn.addEventListener('click', function () {
            if (i <= currentStep) { currentStep = i; saveFormData(); updateUI(); }
        });
    });

    // Initial UI
    updateUI();
});
